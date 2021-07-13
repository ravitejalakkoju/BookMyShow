using System;

namespace BookMyShow.Models
{
    public class Booking
    {
        public int ID { get; set; }

        public int Amount { get; set; }

        public DateTime DateTime { get; set; }

        public BookingStatus Status { get; set; }

        public PaymentMode PaymentMode { get; set; }

        public string CustomerID { get; set; }
    }
}
