using System;
using PetaPoco.NetCore;

namespace BookMyShow.DBModels
{
    [TableName("Customer")]
    public class CustomerView : IEntity
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
