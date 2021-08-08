using System;
using PetaPoco.NetCore;

namespace BookMyShow.Entities
{
    [TableName("Booking")]
    public class Booking: IEntity
    {
        public int ID { get; set; }

        public int Amount { get; set; }

        public DateTime DateTime { get; set; }

        public string Status { get; set; }

        public string PaymentMode { get; set; }

        public string CustomerID { get; set; }
    }
}
