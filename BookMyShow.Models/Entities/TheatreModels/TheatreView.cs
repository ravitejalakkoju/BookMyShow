﻿using System;
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
        public string ScreenID { get; set; }

        public string ShowTime { get; set; }
    }
}
