using System;

namespace HotelManagementSystem
{
    // Room Class
    public class Room
    {
        public string RoomNumber { get; set; }
        public string RoomType { get; set; }
        public double PricePerNight { get; set; }
        public bool IsAvailable { get; set; }

        public Room(string roomNumber, string roomType, double  pricePerNight, bool isAvailable)
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

    // Guest Class
    public class Guest
    {
        public string GuestId { get; set; }
        public string GuestName { get; set; }
        public string RoomNumber { get; set; }
        public string CheckInDate { get; set; }
        public int TotalNights { get; set; }

        public Guest(string guestId, string guestName, string roomNumber, string checkInDate, int totalNights)
        {
            GuestId = guestId;
            GuestName = guestName;
            RoomNumber = roomNumber;
            CheckInDate = checkInDate;
            TotalNights = totalNights;
        }

        public void DisplayGuest()
        {
            Console.WriteLine($"Guest ID    : {GuestId}");
            Console.WriteLine($"Guest Name  : {GuestName}");
            Console.WriteLine($"Room Number : {RoomNumber}");
            Console.WriteLine($"Check In    : {CheckInDate}");
            Console.WriteLine($"Total Nights: {TotalNights}");
        }

        public double CalculateTotalCost(double pricePerNight)
        {
            return pricePerNight * TotalNights;
        }
    }

    public class Program
    {
        // Hotel Lists
        static List<Room> rooms = new List<Room>();
        static List<Guest> guests = new List<Guest>();

        // Preload Hotel Rooms
        static void PreloadRooms()
        {
            rooms.Add(new Room("101", "Single", 25, true));
            rooms.Add(new Room("102", "Single", 30, true));
            rooms.Add(new Room("201", "Double", 45, true));
            rooms.Add(new Room("202", "Double", 50, true));
            rooms.Add(new Room("301", "Suite", 90, true));
            rooms.Add(new Room("302", "Suite", 120, true));
        }

        static void Main(string[] args)
        {
            PreloadRooms();

            // Main Menu
            bool exitApp = false;

            while (!exitApp)
            {
                Console.WriteLine("===================================================");
                Console.WriteLine("     GRAND VISTA HOTEL - MANAGEMENT SYSTEM");
                Console.WriteLine("===================================================");
                Console.WriteLine(" 1. Add New Room");
                Console.WriteLine(" 2. Register New Guest");
                Console.WriteLine(" 3. Book a Room for a Guest");
                Console.WriteLine(" 4. View All Rooms");
                Console.WriteLine(" 5. View All Guests");
                Console.WriteLine(" 6. Search & Filter Rooms");
                Console.WriteLine(" 7. Guest & Booking Statistics");
                Console.WriteLine(" 8. Update Room Price");
                Console.WriteLine(" 9. Guest Lookup by Name");
                Console.WriteLine(" 10. Room Type Breakdown Report");
                Console.WriteLine(" 11. Check Out a Guest");
                Console.WriteLine(" 12. Remove Unavailable Rooms");
                Console.WriteLine(" 13. Extend Guest Stay");
                Console.WriteLine(" 14. Highest Revenue Booking");
                Console.WriteLine(" 15. Guest Pagination Viewer");
                Console.WriteLine(" 0. Exit");
                Console.WriteLine("===================================================");
                Console.Write("Choose an option: ");

                int choice;
                try
                {
                    choice = int.Parse(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please enter a number from 0 to 15.");
                    continue;
                }

                switch (choice)
                {
                    case 1: AddNewRoom(); break;
                    case 2: RegisterNewGuest(); break;
                    case 3: BookRoomForGuest(); break;
                    case 4: ViewAllRooms(); break;
                    case 5: ViewAllGuests(); break;
                    case 6: SearchFilterRooms(); break;
                    case 7: GuestBookingStatistics(); break;
                    case 8: UpdateRoomPrice(); break;
                    case 9: GuestLookupName(); break;
                    case 10: RoomTypeBreakdownReport(); break;
                    case 11: CheckOutGuest(); break;
                    case 12: RemoveUnavailableRooms(); break;
                    case 13: ExtendGuestStay(); break;
                    case 14: HighestRevenueBooking(); break;
                    case 15: GuestPaginationViewer(); break;
                    case 0:
                        exitApp = true;
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option, please choose between 0 and 15.");
                        break;
                }

                Console.WriteLine();
                Console.Write("Press any key to continue...");
                Console.ReadKey();
                Console.Clear();
            }

            // --------------------------------- Cases 1 - 5 (EASY) ------------------------------------------------ 

            // Case 01 Add New Room 
            static void AddNewRoom()
            {

            }

            // Case 02 Register New Guest
            static void RegisterNewGuest()
            {

            }

            // Case 03 Book a Room for a Guest 
            static void BookRoomForGuest()
            {

            }

            // Case 04 View All Rooms 
            static void ViewAllRooms()
            {

            }

            // Case 05 View All Guests 
            static void ViewAllGuests()
            {

            }

            // --------------------------------- Cases 6 - 10 (MEDIUM) ------------------------------------------------ 

            // Case 06 Search & Filter Rooms 
            static void SearchFilterRooms()
            {

            }

            // Case 07 Guest & Booking Statistics 
            static void GuestBookingStatistics()
            {

            }

            // Case 08 Update Room Price 
            static void UpdateRoomPrice()
            {

            }

            // Case 09 Guest Lookup by Name 
            static void GuestLookupName()
            {

            }

            // Case 10 Room Type Breakdown Report 
            static void RoomTypeBreakdownReport()
            {

            }

            // --------------------------------- Cases 11 - 15 (ADVANCED) ------------------------------------------------

            // Case 11 Check Out a Guest 
            static void CheckOutGuest()
            {

            }

            // Case 12 Remove Unavailable Rooms
            static void RemoveUnavailableRooms()
            {

            }

            // Case 13 Extend Guest Stay 
            static void ExtendGuestStay()
            {

            }

            // Case 14 Highest Revenue Booking 
            static void HighestRevenueBooking()
            {

            }

            // Case 15 Guest Pagination Viewer 
            static void GuestPaginationViewer()
            {

            }
        }
    }
}
