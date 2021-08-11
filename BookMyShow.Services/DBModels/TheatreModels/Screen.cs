using PetaPoco.NetCore;
using System;

namespace BookMyShow.DBModels
{
    [TableName("Screen")]
    public class Screen: IEntity
    {
        public int ID { get; set; }

        public string Code { get; set; }

        public int Levels { get; set; }

        public int SeatsPerLevel { get; set; }

        public int TheatreID { get; set; }

        public int MovieID { get; set; }
        
        public int SeatPrice { get; set; }

        public DateTime ShowTime { get; set; }
    }
}
