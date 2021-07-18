

using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ITaskService
    {
        void Add(Task task);
        void Update(Task task);
        void Delete(Task task);
        void DeleteAll();
        List<Task> GetAll();
        Task GetById(int id);
        int GetNextId();
    }
}
