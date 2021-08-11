using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Models.Theatre;

namespace BookMyShow.Services.Interfaces
{
    public interface ISeatService
    {
        public IEnumerable<SeatDTO> GetAllInScreen(int screenId);

        public IEnumerable<SeatsInScreenDTO> GetAvailableSeatsPerScreen();
    }
}
