using System;
using System.Collections.Generic;
using Entities.Concrete;
using Entities.Dtos;

namespace Business.Abstract
{
    public interface IUserService
    {
        void Add(User user);
        void Update(User user);
        void Delete(User user);
        void DeleteAll();
        List<User> GetAll();
        User GetById(int id);
        int GetNextId();
        bool IsUserAlreadyExists(string data);
        int IsEmailOrUsername(string data);
        User GetByEmailOrUserName(string data);
        User Login(UserLoginDto userLoginDto);
        bool IsEmailAlreadyExists(string email);
        bool IsUserNameAlreadyExists(string username);
        void Register(UserRegisterDto userRegisterDto);
    }
}
