using System;
using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IExerciseService
    {
        void Add(Exercise exercise);
        void Update(Exercise exercise);
        void Delete(Exercise exercise);
        void DeleteAll();
        List<Exercise> GetAll();
        Exercise GetById(int id);
        List<Exercise> GetByTitle(string title);
        int GetNextId();
    }
}
