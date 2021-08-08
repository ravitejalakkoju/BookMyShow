using PetaPoco.NetCore;

namespace BookMyShow.Entities
{
    [TableName("Genre")]
    public class Genre: IEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }
    }
}
