using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco.NetCore;

namespace BookMyShow.DBModels
{
    [TableName("Locations")]
    public class LocationView: Location
    {
        public string StateName { get; set; }
    }
}
