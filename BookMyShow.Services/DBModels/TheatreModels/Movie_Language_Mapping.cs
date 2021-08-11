using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco.NetCore;

namespace BookMyShow.DBModels
{
    [TableName("Movie_Language_Mapping")]
    public class Movie_Language_Mapping: IEntity
    {
        public int ID { get; set; }
        public int MovieID { get; set; }

        public int LanguageID { get; set; }
    }
}
