using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PetaPoco.NetCore;

namespace BookMyShow.Entities
{
    [TableName("State")]
    public class State: IEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }
    }
}
