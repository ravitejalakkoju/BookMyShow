using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Services.Repositories.Interfaces
{
    public interface ILocationWrapper
    {
        public ILocationRepository LocationRepository { get; }

        public IStateRepository StateRepository { get; }
    }
}
