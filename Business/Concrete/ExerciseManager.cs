using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class ExerciseManager : IExerciseService
    {
        private IExerciseDal _exerciseDal;

        public ExerciseManager(IExerciseDal exerciseDal)
        {
            _exerciseDal = exerciseDal;
        }

        public void Add(Exercise exercise)
        {
            _exerciseDal.Add(exercise);
        }

        public void Update(Exercise exercise)
        {
            _exerciseDal.Update(exercise);
        }

        public void Delete(Exercise exercise)
        {
            _exerciseDal.Delete(exercise);
        }

        public List<Exercise> GetAll()
        {
            return _exerciseDal.GetAll();
        }

        public Exercise GetById(int id)
        {
            return _exerciseDal.Get(e => e.Id == id);
        }
    }
}
