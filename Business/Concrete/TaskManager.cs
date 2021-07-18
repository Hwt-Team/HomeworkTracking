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
    public class TaskManager : ITaskService
    {
        private ITaskDal _taskDal;

        public TaskManager(ITaskDal taskDal)
        {
            this._taskDal = taskDal;
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(TaskValidator))]
        public void Add(Task task)
        {
            this._taskDal.Add(task);
        }

        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        [ValidationAspect(typeof(TaskValidator))]
        public void Update(Task task)
        {
            this._taskDal.Update(task);
        }


        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void Delete(Task task)
        {
            this._taskDal.Delete(task);
        }


        [CacheRemoveAspect(typeof(MemoryCacheManager))]
        public void DeleteAll()
        {
            this._taskDal.DeleteAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public List<Task> GetAll()
        {
            return this._taskDal.GetAll();
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public Task GetById(int id)
        {
            return this._taskDal.Get(t => t.Id == id);
        }

        [CacheAspect(typeof(MemoryCacheManager))]
        public int GetNextId()
        {
            return this._taskDal.GetNextId();
        }
    }
}
