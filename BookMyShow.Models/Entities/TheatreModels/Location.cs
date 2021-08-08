using PetaPoco.NetCore;

namespace BookMyShow.Entities
{
    [TableName("Location")]
    public class Location: IEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int StateID { get; set; }
    }
}
