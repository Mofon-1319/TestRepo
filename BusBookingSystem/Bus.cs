using System;
using System.Data;
using System.Data.SqlClient;

namespace BusApp
{
    class Bus
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

    class BusManager
    {
        //public void GetBusDetails()
        //{
        //    Console.WriteLine("Enter your Bus Number");
        //    string number = Console.ReadLine();

        //    Console.WriteLine("Enter your Bus Type");
        //    string type = Console.ReadLine();

        //    Console.WriteLine("Enter no. of seats");
        //    int seats = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Enter Source");
        //    string source = Console.ReadLine();

        //    Console.WriteLine("Enter Destination");
        //    string destination = Console.ReadLine();

        //    Console.WriteLine("Enter Arrival Time");
        //    DateTime arrivalTime = Convert.ToDateTime(Console.ReadLine());

        //    Console.WriteLine("Enter Departure Time");
        //    DateTime departureTime = Convert.ToDateTime(Console.ReadLine());

        //    Console.WriteLine("Enter Ticket rate");
        //    int rate = Convert.ToInt32(Console.ReadLine());

        //    Console.WriteLine("Your Message");
        //    string message = Console.ReadLine();

        //    Bus bus = new Bus(number, type, seats, source, destination, arrivalTime, departureTime, rate, message);
        //    BusRepository busRepository = new BusRepository();
        //    busRepository.AddDetails(bus);
        //}
    }

    class BusRepository
    {
        public void AddDetails(Bus bus)
        {

        }
    }
}
