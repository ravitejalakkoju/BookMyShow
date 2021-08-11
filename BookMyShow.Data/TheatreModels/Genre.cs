using PetaPoco.NetCore;

namespace BookMyShow.DBModels
{
    [TableName("Genre")]
    public class Genre: IEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }
    }
}
