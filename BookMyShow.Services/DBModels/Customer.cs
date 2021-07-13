using System;

namespace BookMyShowAPI.DBModels
{
    public class Customer
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string DisplayPicture { get; set; }

        public string Status { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
