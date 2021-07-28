using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco.NetCore;

namespace BookMyShow.Entities
{
    [TableName("Movie_Genre_Mapping")]
    public class Movie_Genre_Mapping
    {
        public int MovieID { get; set; }

        public int GenreID { get; set; }
    }
}
