using PetaPoco.NetCore;

namespace BookMyShow.DBModels
{
    [TableName("Location")]
    public class Location: IEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int StateID { get; set; }
    }
}
