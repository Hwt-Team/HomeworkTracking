using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IGraduateStudentService
    {
        void Add(GraduateStudent graduateStudent);
        void Update(GraduateStudent graduateStudent);
        void Delete(GraduateStudent graduateStudent);
        void DeleteAll();
        List<GraduateStudent> GetAll();
        GraduateStudent GetById(int id);
        int GetNextId();
    }
}
