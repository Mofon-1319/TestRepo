namespace BusBookingSystem.Entity
{
    public class Bus
    {
        public string BusType { get; set; }
        public int seats { get; set; }
        public string source { get; set; }
        public string destination { get; set; }
        public string arrivalTime { get; set; }
        public string departureTime { get; set; }
        public int rate { get; set; }

        public Bus(string type, int seats, string source, string destination,string arrivalTime, string departureTime, int rate)
        {
            this.BusType = type;
            this.seats = seats;
            this.source = source;
            this.destination = destination;
            this.arrivalTime = arrivalTime;
            this.departureTime = departureTime;
            this.rate = rate;
        }
    }
}
