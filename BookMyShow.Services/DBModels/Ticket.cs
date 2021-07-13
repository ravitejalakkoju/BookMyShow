using System;

namespace BookMyShowAPI.DBModels
{
    public class Ticket
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public DateTime ShowTime { get; set; }

        public int SeatID { get; set; }

        public int BookingID { get; set; }
    }
}
