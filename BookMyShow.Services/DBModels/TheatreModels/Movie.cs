using System;
using PetaPoco.NetCore;

namespace BookMyShow.DBModels
{
    [TableName("Movie")]
    public class Movie: IEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime EndingDate { get; set; }

        public int Status { get; set; }

        public string APIID { get; set; }
    }
}
