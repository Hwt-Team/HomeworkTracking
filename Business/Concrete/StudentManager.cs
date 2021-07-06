﻿using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class StudentManager : IStudentService
    {
        private IStudentDal _studentDal;

        public StudentManager(IStudentDal studentDal)
        {
            _studentDal = studentDal;
        }

        public void Add(Student student)
        {
            _studentDal.Add(student);
        }

        public void Update(Student student)
        {
            _studentDal.Update(student);
        }

        public void Delete(Student student)
        {
            _studentDal.Delete(student);
        }

        public List<Student> GetAll()
        {
            return _studentDal.GetAll();
        }

        public Student GetById(int id)
        {
            return _studentDal.Get(s => s.Id == id);
        }

        public List<Student> GetByFirstName(string name)
        {
            return _studentDal.GetAll(s => s.FirstName.Contains(name));
        }

        public List<Student> GetByLastName(string name)
        {
            return _studentDal.GetAll(s => s.LastName.Contains(name));
        }

        public List<Student> GetByFullName(string name)
        {
            return _studentDal.GetAll(s => (s.FirstName + s.LastName).Contains(name));
        }

    }
}
