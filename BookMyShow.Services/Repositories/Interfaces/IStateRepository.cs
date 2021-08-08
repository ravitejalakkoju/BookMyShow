using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;

namespace BookMyShow.Services.Repositories.Interfaces
{
    public interface IStateRepository
    {
        public State Get(int stateId);

        public IEnumerable<State> GetAll();
    }
}
