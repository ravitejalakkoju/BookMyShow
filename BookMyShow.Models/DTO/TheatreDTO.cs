using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyShow.Entities;

namespace BookMyShow.Models.DTO
{
    public class TheatreDTO
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int LocationID { get; set; }

        public int ScreenID { get; set; }

        public DateTime ShowTime { get; set; }
    }
}
