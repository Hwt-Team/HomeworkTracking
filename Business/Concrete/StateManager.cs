using System.Collections.Generic;
using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class StateManager : IStateService
    {
        private IStateDal _stateDal;

        public StateManager(IStateDal stateDal)
        {
            _stateDal = stateDal;
        }

        public void Add(State state)
        {
            this._stateDal.Add(state);
        }

        public void Update(State state)
        {
            this._stateDal.Update(state);
        }

        public void Delete(State state)
        {
            this._stateDal.Delete(state);
        }

        public void DeleteAll()
        {
            this._stateDal.DeleteAll();
        }

        public int GetNextId()
        {
            return this._stateDal.GetNextId();
        }

        public List<State> GetAll()
        {
            return this._stateDal.GetAll();
        }
    }
}
