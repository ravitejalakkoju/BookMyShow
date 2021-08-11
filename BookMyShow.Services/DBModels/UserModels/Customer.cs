using System;
using PetaPoco.NetCore;

namespace BookMyShow.DBModels
{
    [TableName("Customer")]
    public class Customer: IEntity
    {
        [ResultColumn]
        public int ID { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string DisplayPicture { get; set; }

        public int Status { get; set; }

        [ResultColumn]
        public DateTime CreationDate { get; set; }
    }
}
