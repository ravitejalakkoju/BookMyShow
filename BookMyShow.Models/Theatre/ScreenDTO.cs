using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Models.Theatre
{
    public class ScreenDTO
    {
        public int ID { get; set; }

        public string Code { get; set; }

        public int Levels { get; set; }

        public int SeatsPerLevel { get; set; }

        public int TheatreID { get; set; }

        public int MovieID { get; set; }

        public int SeatPrice { get; set; }

        public DateTime ShowTime { get; set; }
    }
}
