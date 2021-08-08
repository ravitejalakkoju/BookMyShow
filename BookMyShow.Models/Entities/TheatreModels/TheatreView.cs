using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco.NetCore;

namespace BookMyShow.Entities
{
    [TableName("TheatreScreens")]
    public class TheatreView: Theatre
    {
        public int ScreenID { get; set; }

        public DateTime ShowTime { get; set; }
    }
}
