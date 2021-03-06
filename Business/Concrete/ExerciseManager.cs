using System.Collections.Generic;
using Business.Abstract;
using Business.CrossCuttingConcerns.Validation;
using Core.Aspects.Postsharp.Caching;
using Core.Aspects.Postsharp.Validation;
using Core.CrossCuttingConcerns.Caching.Microsoft;
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

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(ExerciseValidator))]
        public void Add(Exercise exercise)
        {
            _exerciseDal.Add(exercise);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(ExerciseValidator))]
        public void Update(Exercise exercise)
        {
            _exerciseDal.Update(exercise);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(Exercise exercise)
        {
            _exerciseDal.Delete(exercise);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void DeleteAll()
        {
            this._exerciseDal.DeleteAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Exercise> GetAll()
        {
            return _exerciseDal.GetAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public Exercise GetById(int id)
        {
            return _exerciseDal.Get(e => e.Id == id);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Exercise> GetByTitle(string title)
        {
            return this._exerciseDal.GetAll(e => e.Title.Contains(title));
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public int GetNextId()
        {
            return this._exerciseDal.GetNextId();
        }
    }
}
