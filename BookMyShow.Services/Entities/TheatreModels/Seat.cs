using PetaPoco.NetCore;

namespace BookMyShow.Entities
{
    [TableName("Seat")]
    public class Seat
    {
        public int ID { get; set; }

        public int ScreenID { get; set; }

        public int Price { get; set; }

        public string Code { get; set; }
    }
}
