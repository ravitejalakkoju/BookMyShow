using System;

namespace BookMyShowAPI.DBModels
{
    public class Booking
    {
        public int ID { get; set; }

        public int Amount { get; set; }

        public DateTime DateTime { get; set; }

        public string Status { get; set; }

        public string PaymentMode { get; set; }

        public string CustomerID { get; set; }
    }
}
