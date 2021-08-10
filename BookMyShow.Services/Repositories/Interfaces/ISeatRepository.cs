using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;

namespace BookMyShow.Services.Repositories.Interfaces
{
    public interface ISeatRepository
    {
        public IEnumerable<Seat> GetAllInScreen(int screenId);

        public IEnumerable<SeatsInScreen> GetAvailableSeatsPerScreen();
    }
}
