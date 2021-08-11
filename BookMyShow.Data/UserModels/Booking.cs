using System;
using PetaPoco.NetCore;

namespace BookMyShow.DBModels
{
    [TableName("Booking")]
    public class Booking: IEntity
    {
        [ResultColumn]
        public int ID { get; set; }

        public int Amount { get; set; }

        [ResultColumn]
        public DateTime DateTime { get; set; }

        [ResultColumn]
        public int Status { get; set; }

        public int CustomerID { get; set; }
    }
}
