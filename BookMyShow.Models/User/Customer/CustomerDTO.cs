using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookMyShow.Models.User.Customer
{
    public class CustomerDTO
    {
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string DisplayPicture { get; set; }

        public int Status { get; set; }

        public DateTime CreationDate { get; set; }
    }
}
