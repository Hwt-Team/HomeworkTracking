using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IExerciseService
    {
        void Add(Exercise exercise);
        void Update(Exercise exercise);
        void Delete(Exercise exercise);
        List<Exercise> GetAll();
        Exercise GetById(int id);
    }
}
