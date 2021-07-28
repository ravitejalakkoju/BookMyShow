using System;

namespace BookMyShow.Models
{
    public class Movie
    {
        public int ID { get; set; }

        public DateTime Date { get; set; }

        public MovieCertification Certification { get; set; }

        public DateTime EndingDate { get; set; }

        public MovieStatus Status { get; set; }

        public int APIID { get; set; }
    }
}
