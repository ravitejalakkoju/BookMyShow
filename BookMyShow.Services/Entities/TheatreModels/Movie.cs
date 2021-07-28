using System;
using PetaPoco.NetCore;

namespace BookMyShow.Entities
{
    [TableName("Movie")]
    public class Movie: IAggregateRoot
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public string Certification { get; set; }

        public DateTime EndingDate { get; set; }

        public string Status { get; set; }

        public int APIID { get; set; }
    }
}
