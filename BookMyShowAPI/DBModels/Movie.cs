using System;

namespace BookMyShowAPI.DBModels
{
    public class Movie
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public string Certification { get; set; }

        public DateTime EndingDate { get; set; }

        public string Status { get; set; }

        public int APIID { get; set; }
    }
}
