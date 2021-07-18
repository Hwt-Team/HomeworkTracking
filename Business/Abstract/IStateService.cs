using System.Collections.Generic;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IStateService
    {
        void Add(State state);
        void Update(State state);
        void Delete(State state);
        void DeleteAll();
        int GetNextId();
        List<State> GetAll();
    }
}
