using PetaPoco.NetCore;

namespace BookMyShow.DBModels
{
    [TableName("Language")]
    public class Language: IEntity
    {
        public int ID { get; set; }

        public string Name { get; set; }
    }
}
