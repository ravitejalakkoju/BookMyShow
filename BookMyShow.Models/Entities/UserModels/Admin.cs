using System;
using PetaPoco.NetCore;

namespace BookMyShow.Entities
{
    [TableName("Admin")]
    public class Admin: IEntity
    {
        public int ID { get; set; }

        public int TheatreID { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }
        
        public DateTime CreationDate { get; set; }
    }
}
