using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco.NetCore;

namespace BookMyShow.DBModels
{
    [TableName("MovieWithLocations")]
    public class MovieView: Movie
    {
        public string Genres { get; set; }

        public string Languages { get; set; }

        public int LocationID { get; set; }
    }
}
