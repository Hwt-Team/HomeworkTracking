using System;
using Business.Concrete;
using Core.DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dtos;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            UserManager userManager = new UserManager(new EfUserDal());

            //var userRegister = userManager.Register(new UserRegisterDto
            //{
            //    UserName = "Asim",
            //    Password = "Asim555",
            //    PasswordRepeat = "Asim555",
            //    FirstName = "Asim",
            //    LastName = "Alizade",
            //    Email = "asimelizade01@gmail.com"
            //});

            //userManager.Add(userRegister);

            var userLogin = userManager.Login(new UserLoginDto
            {
                EmailOrUsername = "Asim",
                Password = "Asim555"
            });

            Console.WriteLine(userLogin.Id);
            Console.WriteLine(userLogin.UserName);
            Console.WriteLine(userLogin.PasswordHash);
            Console.WriteLine(userLogin.PasswordSalt);
            Console.WriteLine(userLogin.FirstName);
            Console.WriteLine(userLogin.LastName);
            Console.WriteLine(userLogin.Email);
            Console.WriteLine(userLogin.Status);

            //userManager.Delete(new User
            //{
            //    Id = 1
            //});


            // This is Test1 branch


            // Here is test branch.



            Console.ReadLine();
        }
    }
}
