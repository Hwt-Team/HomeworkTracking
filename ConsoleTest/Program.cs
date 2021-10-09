using System;
using Business.Concrete;
using Core.DataAccess.Concrete.EntityFramework;
using Core.Entities.Dtos;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Dtos;

namespace ConsoleTest
{
    class Program
    {
        static void Main(string[] args)
        {
            //string name = "Student Exercises Search";

            //for (int i = 0; i < name.Length - 1; i++)
            //{
            //    result += name[i];
            //    if (char.IsUpper(name[i + 1])) result += " ";
            //}
            //EfMainClaimDal claimDal = new EfMainClaimDal();
            //var result= claimDal.GetUserMainClaimsDetails(1);


            //if (result == null)
            //{
            //    Console.WriteLine("null");
            //}
            //foreach (var item in result)
            //{
            //    Console.WriteLine($" {item.Name}  {item.Priority}");
            //}

            UserManager manager = new UserManager(new EfUserDal(),new EfStudentDal(),
                new EfGraduateStudentDal(),new EfStudyingStudentDal(),new EfMainClaimDal());
            manager.Register(new UserRegisterDto
            {
                Email = "abc@gmail.com",
                FirstName = "Abc",
                LastName = "Abc",
                Password = "Abc123.",
                PasswordRepeat = "Abc123.",
                UserName = "Abc"
            });
            Console.WriteLine("Hello");
            Console.ReadLine();
        }
    }
}
