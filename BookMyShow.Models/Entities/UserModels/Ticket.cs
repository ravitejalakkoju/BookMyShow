using System;
using PetaPoco.NetCore;

namespace BookMyShow.Entities
{
    [TableName("Ticket")]
    public class Ticket: IEntity
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public DateTime ShowTime { get; set; }

        public int SeatID { get; set; }

        public int BookingID { get; set; }
    }
}
