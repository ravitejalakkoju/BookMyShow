using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco.NetCore;

namespace BookMyShow.Models.Theatre
{
    public class SeatsInScreenDTO
    {
        public int ScreenID { get; set;}

        public decimal SeatCount { get; set; }
    }
}
