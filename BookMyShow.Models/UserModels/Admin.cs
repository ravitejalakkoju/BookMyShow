using System;

namespace BookMyShow.Models
{
    class Admin
    {
        int ID { get; set; }

        int TheatreID { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        
        public DateTime CreationDate { get; set; }
    }
}
