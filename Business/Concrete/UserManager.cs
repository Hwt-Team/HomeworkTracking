using System;
using System.Collections.Generic;
using Business.Abstract;
using Business.CrossCuttingConcerns.Validation;
using Core.Aspects.Postsharp.Caching;
using Core.Aspects.Postsharp.Validation;
using Core.CrossCuttingConcerns.Caching.Microsoft;
using Core.DataAccess.Abstract;
using Core.Entities.Concrete;
using Core.Entities.Dtos;
using Core.Utilities.Security;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;
        private readonly IStudentDal _studentDal;
        private readonly IGraduateStudentDal _graduateStudentDal;
        private readonly IStudyingStudentDal _studyingStudentDal;
        private readonly IMainClaimDal _mainClaimDal;
        public UserManager(IUserDal userDal, IStudentDal studentDal, IGraduateStudentDal graduateStudentDal, IStudyingStudentDal studyingStudentDal, IMainClaimDal mainClaimDal)
        {
            _userDal = userDal;
            _studentDal = studentDal;
            _graduateStudentDal = graduateStudentDal;
            _studyingStudentDal = studyingStudentDal;
            _mainClaimDal = mainClaimDal;
        }


        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(UserValidator))]
        public void Add(User user)
        {
            this._userDal.Add(user);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(UserValidator))]
        public void Update(User user)
        {
            this._userDal.Update(user);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(User user)
        {
            this._userDal.Delete(user);

            if (!(this._studentDal.Get(s => s.Id == user.Id) is null))
            {
                this._studentDal.Delete(new Student
                {
                    Id = user.Id
                });

                if (!(this._graduateStudentDal.Get(s => s.Id == user.Id) is null))
                    this._graduateStudentDal.Delete(new GraduateStudent
                    {
                        Id = user.Id
                    });

                if (!(this._studyingStudentDal.Get(s => s.Id == user.Id) is null))
                    this._studyingStudentDal.Delete(new StudyingStudent
                    {
                        Id = user.Id
                    });
            }
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void DeleteAll()
        {
            this._userDal.DeleteAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<User> GetAll()
        {
            return this._userDal.GetAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public User GetById(int id)
        {
            return this._userDal.Get(u => u.Id == id);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public int GetNextId()
        {
            return this._userDal.GetNextId();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public bool IsUserAlreadyExists(string data)
        {
            if (this.IsEmailOrUsername(data) == 1)
            {
                var user = this._userDal.Get(u => u.Email == data);
                if (user == null) return false;
            }
            else
            {
                var user = this._userDal.Get(u => u.UserName == data);
                if (user == null) return false;
            }
            return true;
        }

        /// <summary>
        /// Provides to decide email or username
        /// </summary>
        /// <param name="data"></param>
        /// <returns>If data format is email returns 1, username returns 0.</returns>
        [CacheAspect(typeof(MemoryCacheManager))]
        public int IsEmailOrUsername(string data)
        {
            return data.Contains("@") ? 1 : 0;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public User GetByEmailOrUserName(string data)
        {
            return this.IsEmailOrUsername(data) == 1 
                ? this._userDal.Get(u => u.Email == data) 
                : this._userDal.Get(u => u.UserName == data);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(UserLoginValidator))]
        public User Login(UserLoginDto userLoginDto)
        {
            if (!IsUserAlreadyExists(userLoginDto.EmailOrUsername))
            {
                throw new Exception("User not found.");
            }

            var user = this.GetByEmailOrUserName(userLoginDto.EmailOrUsername);

            if (!HashingHelper.VerifyPassword(userLoginDto.Password, user.PasswordHash, user.PasswordSalt))
            {
                throw new Exception("Incorrect password.");
            }

            return user;
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public bool IsEmailAlreadyExists(string email) => this._userDal.Get(u => u.Email == email) != null;

        [CacheAspect(typeof(MemoryCacheManager))]
        public bool IsUserNameAlreadyExists(string username) => this._userDal.Get(u => u.UserName == username) != null;

        [CacheAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(UserRegisterValidator))]
        public void Register(UserRegisterDto userRegisterDto)
        {
            if (IsEmailAlreadyExists(userRegisterDto.Email))
            {
                throw new Exception("Email already exists.");
            }

            if (IsUserAlreadyExists(userRegisterDto.UserName))
            {
                throw new Exception("Username already exists.");
            }

            HashingHelper.ComputeHash(64, userRegisterDto.Password, out var passwordHash, out var passwordSalt);

            var user = new User
            {
                Id = this._userDal.GetNextId(),
                UserName = userRegisterDto.UserName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Email = userRegisterDto.Email,
                FirstName = userRegisterDto.FirstName,
                LastName = userRegisterDto.LastName,
                Status = true
            };

            this.Add(user);
        }

        public PasswordDetails HashPassword(string pass)
        {
            HashingHelper.ComputeHash(64, pass, out var passwordHash, out var passwordSalt);

            return new PasswordDetails
            {
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt
            };
        }

        public PasswordDetails GetPassDetailsById(int userId)
        {
            var user = this._userDal.Get(u => u.Id == userId);
            return new PasswordDetails
            {
                PasswordHash = user.PasswordHash,
                PasswordSalt = user.PasswordSalt
            };
        }

        public bool BanUser(User currentUser, User userToBan)
        {
            var currentUserClaims = _mainClaimDal.GetMainClaimsByUserId(currentUser.Id);
            var userToBanClaims = _mainClaimDal.GetMainClaimsByUserId(userToBan.Id);
            if (currentUserClaims.Count == 0 ) return false;
            if (userToBanClaims.Count == 0)
            {
                _userDal.Update(userToBan);
                return true;
            }
            for (int i = 0; i < currentUserClaims.Count; i++)
            {                              
                if (currentUserClaims[i].Priority <= userToBanClaims[i].Priority 
                    && currentUserClaims[i].Name.ToLower()== userToBanClaims[i].Name.ToLower()
                    && currentUserClaims[i].Name.ToLower() == "admin")
                {
                    _userDal.Update(userToBan);                    
                    return true;
                }
                else if(currentUserClaims[i].Priority < userToBanClaims[i].Priority)
                {
                    _userDal.Update(userToBan);
                    return true;
                }
            }
            return false;
        }
    }
}
