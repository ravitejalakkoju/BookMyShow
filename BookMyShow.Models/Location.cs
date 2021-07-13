namespace BookMyShow.Models
{
    public class Location
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public string State { get; set; }

        public int PinCode { get; set; }

        public LocationType Type { get; set; }
    }
}
