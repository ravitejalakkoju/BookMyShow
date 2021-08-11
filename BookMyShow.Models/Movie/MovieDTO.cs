using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Models.Movie
{
    public class MovieDTO
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public DateTime ReleaseDate { get; set; }

        public DateTime EndingDate { get; set; }

        public int Status { get; set; }

        public string APIID { get; set; }

        public string Genres { get; set; }

        public string Languages { get; set; }
    }
}
