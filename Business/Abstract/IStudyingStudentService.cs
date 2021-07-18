using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStudyingStudentService
    {
        void Add(StudyingStudent studyingStudent);
        void Update(StudyingStudent studyingStudent);
        void Delete(StudyingStudent studyingStudent);
        void DeleteAll();
        List<StudyingStudent> GetAll();
        int GetNextId();
        StudyingStudent GetById(int id);
    }
}
