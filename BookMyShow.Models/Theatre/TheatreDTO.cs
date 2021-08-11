using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Models.Theatre
{
    public class TheatreDTO
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int LocationID { get; set; }

        public string ScreenIDs { get; set; }

        public string ShowTimes { get; set; }
    }
}
