using PetaPoco.NetCore;

namespace BookMyShow.Entities
{
    [TableName("Language")]
    public class Language
    {
        public int ID { get; set; }

        public string Name { get; set; }
    }
}
