using System;
using PetaPoco.NetCore;

namespace BookMyShow.DBModels
{
    [TableName("Ticket")]
    public class Ticket: IEntity
    {
        [ResultColumn]
        public int ID { get; set; }

        public int SeatID { get; set; }

        public int BookingID { get; set; }
    }
}
