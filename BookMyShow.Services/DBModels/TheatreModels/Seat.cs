using PetaPoco.NetCore;

namespace BookMyShow.DBModels
{
    [TableName("Seat")]
    public class Seat: IEntity
    {
        public int ID { get; set; }

        public int ScreenID { get; set; }

        public string Code { get; set; }

        public int Active { get; set; }

        public int Blocked { get; set; }
    }
}
