using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStudentService
    {
        void Add(Student student);
        void Update(Student student);
        void Delete(Student student);
        void DeleteAll();
        List<Student> GetAll();
        Student GetById(int id);
        List<Student> GetByFirstName(string name);
        List<Student> GetByLastName(string name);
        List<Student> GetByFullName(string name);
        Student GetLastRecord();
    }
}
