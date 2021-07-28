using PetaPoco.NetCore;

namespace BookMyShow.Entities
{
    [TableName("Screen")]
    public class Screen
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Levels { get; set; }

        public int SeatsPerLevel { get; set; }

        public int TheatreID { get; set; }

        public int MovieID { get; set; }
    }
}
