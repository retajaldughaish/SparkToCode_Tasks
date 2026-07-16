using System;
using System.Collections.Generic;
using System.Text;

namespace HotelManagementSystem
{
    // Room Class
    public class Room
    {
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        public Room(string roomNumber, string roomType, double pricePerNight, bool isAvailable)
        {
            RoomNumber = roomNumber;
            RoomType = roomType;
            PricePerNight = pricePerNight;
            IsAvailable = isAvailable;
        }

        public void DisplayRoom()
        {
            Console.WriteLine($"Room Number : {RoomNumber}");
            Console.WriteLine($"Room Type   : {RoomType}");
            Console.WriteLine($"Price       : {PricePerNight:F2} OMR");
            Console.WriteLine($"Status      : {(IsAvailable ? "Available" : "Booked")}");
        }
    }
}
