using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Services.Repositories.Interfaces
{
    public interface ITheatreWrapper
    {
        public ITheatreRepository TheatreRepository { get; }

        public IScreenRepository ScreenRepository { get; }

        public ISeatRepository SeatRepository { get; }
    }
}
