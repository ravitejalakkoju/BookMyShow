﻿using PetaPoco.NetCore;

namespace BookMyShow.Entities
{
    [TableName("Theatre")]
    public class Theatre: IEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int LocationID { get; set; }
    }
}
