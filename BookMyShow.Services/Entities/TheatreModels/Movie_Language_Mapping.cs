using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco.NetCore;

namespace BookMyShow.Entities
{
    [TableName("Movie_Language_Mapping")]
    public class Movie_Language_Mapping
    {
        public int MovieID { get; set; }

        public int LanguageID { get; set; }
    }
}
