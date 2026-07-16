using System;
using System.Collections.Generic;
using System.Linq;

namespace HotelManagementSystem
{
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
                Console.Write("Enter A Room Number: ");
                string roomNumber = Console.ReadLine()?.Trim();

                if (string.IsNullOrEmpty(roomNumber) || !int.TryParse(roomNumber, out int rn) || rn <= 0)
                {
                    Console.WriteLine("Invalid input. Room number must be a positive number.");
                    return;
                }

                if (rooms.Any(r => r.RoomNumber == roomNumber))
                {
                    Console.WriteLine("A Room with that Number Already Exists.");
                    return;
                }

                Console.Write("Enter Room Type (Single/Double/Suite): ");
                string roomTypeInput = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(roomTypeInput))
                {
                    Console.WriteLine("Room Type Cannot Be Empty.");
                    return;
                }

                string[] allowedTypes = new[] { "Single", "Double", "Suite" };
                string roomType = allowedTypes.FirstOrDefault(t => t.Equals(roomTypeInput, StringComparison.OrdinalIgnoreCase));
                if (roomType == null)
                {
                    Console.WriteLine("Invalid room type. Must be Single, Double, or Suite.");
                    return;
                }

                Console.Write("Enter Price Per Night: ");
                string priceInput = Console.ReadLine()?.Trim();
                if (!double.TryParse(priceInput, out double price) || price <= 0)
                {
                    Console.WriteLine("Invalid Input. Price must be a Positive Number.");
                    return;
                }

                var newRoomObj = new Room(roomNumber, roomType, price, true);
                rooms.Add(newRoomObj);

                Console.WriteLine("Room Added Successfully.");
                newRoomObj.DisplayRoom();
                Console.WriteLine($"Total Rooms: {rooms.Count}");
            }

            // Case 02 Register New Guest
            static void RegisterNewGuest()
            {
                Console.Write("Enter Guest Name: ");
                string guestName = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(guestName))
                {
                    Console.WriteLine("Guest Name Cannot Be Empty.");
                    return;
                }

                Console.Write("Enter Check-In Date: ");
                string checkInDate = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(checkInDate))
                {
                    Console.WriteLine("Check-In date cannot be empty.");
                    return;
                }

                Console.Write("Enter Number of Nights: ");
                string nightsInput = Console.ReadLine()?.Trim();
                if (!int.TryParse(nightsInput, out int totalNights) || totalNights <= 0)
                {
                    Console.WriteLine("Invalid input. Number of nights must be a positive integer.");
                    return;
                }

                string guestId = $"G{(guests.Count + 1).ToString("D3")}";

                Guest newGuest = new Guest(guestId, guestName, "Not Assigned", checkInDate, totalNights);
                guests.Add(newGuest);

                Console.WriteLine("Guest registered successfully.");
                newGuest.DisplayGuest();
                Console.WriteLine($"Total Guests: {guests.Count}");
            }

            // Case 03 Book a Room for a Guest 
            static void BookRoomForGuest()
            {
                Console.Write("Enter Guest ID (e.g. G001): ");
                string guestId = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(guestId))
                {
                    Console.WriteLine("Guest ID Cannot Be Empty.");
                    return;
                }

                Console.Write("Enter Desired Room Number: ");
                string roomNumber = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(roomNumber))
                {
                    Console.WriteLine("Room Number Cannot Be Empty.");
                    return;
                }

                var guest = guests.FirstOrDefault(g => g.GuestId.Equals(guestId, StringComparison.OrdinalIgnoreCase));
                if (guest == null)
                {
                    Console.WriteLine("Guest Not Found.");
                    return;
                }

                var room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
                if (room == null)
                {
                    Console.WriteLine("Room Not Found.");
                    return;
                }

                if (!room.IsAvailable)
                {
                    Console.WriteLine("Room is Already Booked.");
                    return;
                }

                guest.RoomNumber = room.RoomNumber;
                room.IsAvailable = false;

                Console.WriteLine("Booking confirmed:");
                Console.WriteLine($"Guest Name   : {guest.GuestName}");
                Console.WriteLine($"Guest ID     : {guest.GuestId}");
                Console.WriteLine($"Room Number  : {room.RoomNumber}");
                Console.WriteLine($"Room Type    : {room.RoomType}");
                Console.WriteLine($"Price/Night  : {room.PricePerNight:F2} OMR");
                Console.WriteLine($"Total Nights : {guest.TotalNights}");
                double totalCost = guest.CalculateTotalCost(room.PricePerNight);
                Console.WriteLine($"Total Cost   : {totalCost:F2} OMR");
            }

            // Case 04 View All Rooms 
            static void ViewAllRooms()
            {
                if (rooms.Count == 0)
                {
                    Console.WriteLine("No rooms have been added yet.");
                    return;
                }

                Console.WriteLine($"Total Rooms: {rooms.Count}");

                var ordered = rooms.OrderBy(r => r.RoomNumber).ToList();

                foreach (var r in ordered)
                {
                    Console.WriteLine("------------------------------");
                    r.DisplayRoom();
                }
                Console.WriteLine("------------------------------");
            }

            // Case 05 View All Guests 
            static void ViewAllGuests()
            {
                if (guests.Count == 0)
                {
                    Console.WriteLine("No guests have been registered yet.");
                    return;
                }

                Console.WriteLine($"Total Guests: {guests.Count}");

                var ordered = guests.OrderBy(g => g.GuestName).ToList();

                foreach (var g in ordered)
                {
                    Console.WriteLine("------------------------------");
                    g.DisplayGuest();
                }
                Console.WriteLine("------------------------------");
            }

            // --------------------------------- Cases 6 - 10 (MEDIUM) ------------------------------------------------ 

            // Case 06 Search & Filter Rooms 
            static void SearchFilterRooms()
            {
                while (true)
                {
                    Console.WriteLine("\nSearch & Filter Rooms");
                    Console.WriteLine("1. Show All Available Rooms");
                    Console.WriteLine("2. Filter by Room Type");
                    Console.WriteLine("3. Filter by Max Price");
                    Console.WriteLine("4. Room Price Statistics (total, available, avg, min, max)");
                    Console.WriteLine("0. Back");
                    Console.Write("Choose an Option: ");

                    string opt = Console.ReadLine();
                    if (!int.TryParse(opt, out int choice))
                    {
                        Console.WriteLine("Invalid Input. Enter a Number.");
                        continue;
                    }

                    if (choice == 0) return;

                    switch (choice)
                    {
                        case 1:
                            {
                                var results = rooms.Where(r => r.IsAvailable).OrderBy(r => r.PricePerNight).ToList();
                                if (!results.Any())
                                {
                                    Console.WriteLine("No Rooms Found for The Selected Criteria.");
                                    break;
                                }

                                Console.WriteLine($"Found {results.Count()} Available Room(S):");
                                foreach (var r in results)
                                {
                                    Console.WriteLine("------------------------------");
                                    r.DisplayRoom();
                                }
                                Console.WriteLine("------------------------------");
                                break;
                            }

                        case 2: 
                            {
                                Console.Write("Enter Room Type to Filter (Single/Double/Suite): ");
                                string typeInput = Console.ReadLine()?.Trim();
                                if (string.IsNullOrEmpty(typeInput))
                                {
                                    Console.WriteLine("Room Type Cannot Be Empty.");
                                    break;
                                }

                                var results = rooms.Where(r => r.RoomType.Equals(typeInput, StringComparison.OrdinalIgnoreCase))
                                                   .OrderBy(r => r.RoomNumber)
                                                   .ToList();
                                if (!results.Any())
                                {
                                    Console.WriteLine("No Rooms Found for the Selected Criteria.");
                                    break;
                                }

                                Console.WriteLine($"Found {results.Count()} Room(s) of Type '{typeInput}':");
                                foreach(var r in results)
                                {
                                    Console.WriteLine("------------------------------");
                                    r.DisplayRoom();
                                }
                                Console.WriteLine("------------------------------");
                                break;
                            }

                        case 3:
                            {
                                Console.Write("Enter Maximum Price: ");
                                string maxInput = Console.ReadLine()?.Trim();
                                if (!double.TryParse(maxInput, out double maxPrice) || maxPrice <= 0)
                                {
                                    Console.WriteLine("Invalid Input. Enter a Positive Number for Price.");
                                    break;
                                }

                                var results = rooms.Where(r => r.IsAvailable && r.PricePerNight <= maxPrice)
                                                   .OrderBy(r => r.PricePerNight)
                                                   .ToList();
                                if (!results.Any())
                                {
                                    Console.WriteLine("No Rooms Found for the Selected Criteria.");
                                    break;
                                }

                                Console.WriteLine($"Found {results.Count()} Available Room(s) At or Below {maxPrice:F2}:");
                                foreach (var r in results)
                                {
                                    Console.WriteLine("------------------------------");
                                    r.DisplayRoom();
                                }
                                Console.WriteLine("------------------------------");
                                break;
                            }

                        case 4:
                            {
                                if (!rooms.Any())
                                {
                                    Console.WriteLine("No Rooms Have Been Added Yet.");
                                    break;
                                }

                                int total = rooms.Count();
                                int available = rooms.Count(r => r.IsAvailable);
                                double avg = rooms.Average(r => r.PricePerNight);
                                double min = rooms.Min(r => r.PricePerNight);
                                double max = rooms.Max(r => r.PricePerNight);

                                Console.WriteLine("Room Price Statistics:");
                                Console.WriteLine($"Total Rooms     : {total}");
                                Console.WriteLine($"Available Rooms : {available}");
                                Console.WriteLine($"Average Price   : {avg:F2} OMR");
                                Console.WriteLine($"Cheapest Price  : {min:F2} OMR");
                                Console.WriteLine($"Most Expensive  : {max:F2} OMR");
                                break;
                            }

                        default:
                            Console.WriteLine("Invalid Option. Choose 0-4.");
                            break;
                    }

                    Console.WriteLine();
                    Console.Write("Press any key to return to the Search menu...");
                    Console.ReadKey();
                    Console.WriteLine();
                }
            }

            // Case 07 Guest & Booking Statistics 
            static void GuestBookingStatistics()
            {
                int totalGuests = guests.Count();
                int guestsWithRoom = guests.Count(g => g.RoomNumber != "Not Assigned");
                Console.WriteLine($"Total registered guests: {totalGuests}");
                Console.WriteLine($"Guests with an assigned room: {guestsWithRoom}");

                int totalRooms = rooms.Count();
                int bookedRooms = rooms.Count(r => !r.IsAvailable);
                Console.WriteLine($"Total rooms: {totalRooms}");
                Console.WriteLine($"Currently booked rooms: {bookedRooms}");

                var bookedGuests = guests
                    .Where(g => g.RoomNumber != "Not Assigned" && rooms.Any(r => r.RoomNumber == g.RoomNumber))
                    .ToList();

                if (!bookedGuests.Any())
                {
                    Console.WriteLine("No active bookings recorded.");
                    return;
                }

                double avgNights = bookedGuests.Average(g => g.TotalNights);
                Console.WriteLine($"Average nights (booked guests): {avgNights:F2}");

                var topSpenders = bookedGuests
                    .OrderByDescending(g =>
                        {
                            var room = rooms.FirstOrDefault(r => r.RoomNumber == g.RoomNumber);
                            return g.CalculateTotalCost(room.PricePerNight);
                        })
                    .Take(3)
                    .ToList();

                Console.WriteLine("\nTop 3 Highest Revenue Guests:");
                foreach (var g in topSpenders)
                {
                    var room = rooms.FirstOrDefault(r => r.RoomNumber == g.RoomNumber);
                    double totalCost = g.CalculateTotalCost(room.PricePerNight);
                    Console.WriteLine($"{g.GuestName} — Room {g.RoomNumber} — OMR {totalCost:F2}");
                }

                var summaries = bookedGuests
                    .Select(g =>
                    {
                        var room = rooms.FirstOrDefault(r => r.RoomNumber == g.RoomNumber);
                        return $"{g.GuestName} — Room {g.RoomNumber} — {g.TotalNights} nights — OMR {g.CalculateTotalCost(room.PricePerNight):F2}";
                    })
                    .ToList();

                Console.WriteLine("\nBooked guest summaries:");
                foreach (var summary in summaries)
                {
                    Console.WriteLine(summary);
                }
            }

            // Case 08 Update Room Price 
            static void UpdateRoomPrice()
            {
                Console.Write("Enter Room Number: ");
                string roomNumber = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(roomNumber))
                {
                    Console.WriteLine("Room Number Cannot Be Empty.");
                    return;
                }

                var room = rooms.FirstOrDefault(r => r.RoomNumber == roomNumber);
                if (room == null) 
                {
                    Console.WriteLine("Room Not Found.");
                    return;
                }

                Console.Write($"Current Price for Room {room.RoomNumber} is {room.PricePerNight:F2} OMR. Enter new Price: ");
                string priceInput = Console.ReadLine()?.Trim();
                if (!double.TryParse(priceInput, out double newPrice) || newPrice <= 0)
                {
                    Console.WriteLine("Invalid Input. Price must be a Positive Number.");
                    return;
                }

                double oldPrice = room.PricePerNight;
                room.PricePerNight = newPrice;

                Console.WriteLine($"Price Updated for Room {room.RoomNumber}: {oldPrice:F2} OMR -> {room.PricePerNight:F2} OMR");
            }

            // Case 09 Guest Lookup by Name 
            static void GuestLookupName()
            {
                Console.Write("Enter Name or Partial Name to Search for: ");
                string query = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(query)) 
                {
                    Console.WriteLine("Search Text Cannot be Empty.");
                    return;
                }

                var matches = guests
                    .Where(g => !string.IsNullOrEmpty(g.GuestName) &&
                                g.GuestName.Contains(query, StringComparison.OrdinalIgnoreCase))
                    .ToList();

                if (!matches.Any()) 
                {
                    Console.WriteLine("No Guests matched that Search.");
                    return;
                }

                Console.WriteLine($"Found {matches.Count()} matching guest(s):");
                foreach (var g in matches) 
                {
                    Console.WriteLine($"Guest ID: {g.GuestId} | Name: {g.GuestName} | Room: {g.RoomNumber}");
                }
            }

            // Case 10 Room Type Breakdown Report 
            static void RoomTypeBreakdownReport()
            {
                string[] types = new[] { "Single", "Double", "Suite" };

                if (!rooms.Any()) 
                {
                    Console.WriteLine("No rooms have been added yet.");
                    return;
                }

                foreach (var type in types) 
                {
                    int count = rooms.Count(r => r.RoomType.Equals(type, StringComparison.OrdinalIgnoreCase));

                    string avgDisplay;
                    if (count == 0)
                    {
                        avgDisplay = "N/A";
                    }
                    else
                    {
                        double avg = rooms.Where(r => r.RoomType.Equals(type, StringComparison.OrdinalIgnoreCase))
                                          .Average(r => r.PricePerNight);
                        avgDisplay = $"{avg:F2} OMR";
                    }

                    Console.WriteLine($"{type} Rooms");
                    Console.WriteLine($"Count          : {count}");
                    Console.WriteLine($"Average Price  : {avgDisplay}");
                    Console.WriteLine("----------------------------");
                }

                double overallAvg = rooms.Average(r => r.PricePerNight);
                Console.WriteLine($"\nOverall Average Price Across all Rooms: {overallAvg:F2} OMR");
            }

            // --------------------------------- Cases 11 - 15 (ADVANCED) ------------------------------------------------

            // Case 11 Check Out a Guest 
            static void CheckOutGuest()
            {
                Console.Write("Enter Guest ID to Check out: ");
                string guestId = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(guestId)) 
                {
                    Console.WriteLine("Guest ID Cannot be empty.");
                    return;
                }

                var guest =guests.FirstOrDefault(g => g.GuestId.Equals(guestId, StringComparison.OrdinalIgnoreCase));
                if (guest == null) 
                {
                    Console.WriteLine("Guest Not Found.");
                    return;
                }

                if (guest.RoomNumber == "Not Assigned")
                {
                    Console.WriteLine("This guest has no active booking.");
                    return;
                }

                var room = rooms.FirstOrDefault(r => r.RoomNumber == guest.RoomNumber);
                if (room == null) 
                {
                    Console.WriteLine("Room not found.");
                    return;
                }

                double totalCost = guest.CalculateTotalCost(room.PricePerNight);
                Console.WriteLine("\n========== FINAL BILL ==========");
                Console.WriteLine($"Guest Name    : {guest.GuestName}");
                Console.WriteLine($"Room Number   : {room.RoomNumber}");
                Console.WriteLine($"Room Type     : {room.RoomType}");
                Console.WriteLine($"Check In      : {guest.CheckInDate}");
                Console.WriteLine($"Total Nights  : {guest.TotalNights}");
                Console.WriteLine($"Price/Night   : {room.PricePerNight:F2} OMR");
                Console.WriteLine($"Total Cost    : {totalCost:F2} OMR");
                Console.WriteLine("================================");

                Console.Write("Confirm checkout? (Y/N): ");
                string confirm = Console.ReadLine()?.Trim();

                if (string.Equals(confirm, "Y", StringComparison.OrdinalIgnoreCase))
                {
                    room.IsAvailable = true;
                    guests.Remove(guest);

                    Console.WriteLine("Checkout completed successfully.");
                    Console.WriteLine($"Total Guests Remaining: {guests.Count()}");
                    Console.WriteLine($"Total Rooms: {rooms.Count()}");

                    bool isNowAvailable = rooms.Any(r => r.RoomNumber == room.RoomNumber && r.IsAvailable);
                    Console.WriteLine($"Room {room.RoomNumber} is now available: {isNowAvailable}");
                }
                else if (string.Equals(confirm, "N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Checkout cancelled. No changes were made.");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter Y or N.");
                }
            }

            // Case 12 Remove Unavailable Rooms
            static void RemoveUnavailableRooms()
            {
                var removable = rooms
                    .Where(r => !r.IsAvailable &&
                                !guests.Any(g => g.RoomNumber.Equals(r.RoomNumber, StringComparison.OrdinalIgnoreCase)))
                    .OrderBy(r => r.RoomNumber)
                    .ToList();

                if (!removable.Any())
                {
                    Console.WriteLine("All unavailable rooms are currently occupied. No rooms can be decommissioned.");
                    return;
                }

                Console.WriteLine($"Found {removable.Count} removable room(s):");

                foreach (var room in removable)
                {
                    Console.WriteLine("--------------------------------");
                    Console.WriteLine($"Room Number : {room.RoomNumber}");
                    Console.WriteLine($"Room Type   : {room.RoomType}");
                    Console.WriteLine($"Price       : {room.PricePerNight:F2} OMR");
                }

                Console.WriteLine("--------------------------------");

                Console.Write($"Confirm removal of these {removable.Count} room(s)? (Y/N): ");
                string input = Console.ReadLine()?.Trim();

                if (string.Equals(input, "Y", StringComparison.OrdinalIgnoreCase))
                {
                    int removedCount = rooms.RemoveAll(r =>
                        !r.IsAvailable &&
                        !guests.Any(g => g.RoomNumber.Equals(r.RoomNumber, StringComparison.OrdinalIgnoreCase)));

                    Console.WriteLine($"{removedCount} room(s) removed successfully.");
                    Console.WriteLine($"Updated Total Rooms: {rooms.Count}");

                    var remainingRooms = rooms
                        .OrderBy(r => r.RoomNumber)
                        .Select(r => new
                        {
                            r.RoomNumber,
                            r.RoomType
                        });

                    Console.WriteLine("\nRemaining Rooms:");

                    foreach (var room in remainingRooms)
                    {
                        Console.WriteLine($"Room Number: {room.RoomNumber} | Room Type: {room.RoomType}");
                    }
                }
                else if (string.Equals(input, "N", StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("No rooms were removed.");
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please enter Y or N.");
                }
            }

            // Case 13 Extend Guest Stay 
            static void ExtendGuestStay()
            {
                Console.Write("Enter Guest ID: ");
                string guestId = Console.ReadLine()?.Trim();
                if (string.IsNullOrEmpty(guestId))
                {
                    Console.WriteLine("Guest ID cannot be empty.");
                    return;
                }

                var guest = guests.FirstOrDefault(g => g.GuestId.Equals(guestId, StringComparison.OrdinalIgnoreCase));
                if (guest == null)
                {
                    Console.WriteLine("Guest not found.");
                    return;
                }

                if (guest.RoomNumber == "Not Assigned")
                {
                    Console.WriteLine("This guest has no active booking to extend.");
                    return;
                }

                var room = rooms.FirstOrDefault(r => r.RoomNumber == guest.RoomNumber);
                if (room == null)
                {
                    Console.WriteLine("Linked room not found.");
                    return;
                }

                Console.Write("Enter number of additional nights: ");
                string nightsInput = Console.ReadLine()?.Trim();
                if (!int.TryParse(nightsInput, out int additionalNights) || additionalNights <= 0)
                {
                    Console.WriteLine("Invalid input. Number of nights must be a positive integer.");
                    return;
                }

                guest.TotalNights += additionalNights;

                double newTotalCost = guest.CalculateTotalCost(room.PricePerNight);
                Console.WriteLine("Stay extended successfully.");
                Console.WriteLine($"Updated Total Nights : {guest.TotalNights}");
                Console.WriteLine($"New Total Cost       : OMR {newTotalCost:F2}");
            }

            // Case 14 Highest Revenue Booking 
            static void HighestRevenueBooking()
            {
                var activeBookings = guests
                    .Where(g => g.RoomNumber != "Not Assigned" && rooms.Any(r => r.RoomNumber == g.RoomNumber));

                if (!activeBookings.Any())
                {
                    Console.WriteLine("No active bookings recorded.");
                    return;
                }

                var ranked = activeBookings
                    .Select(g =>
                    {
                        var room = rooms.FirstOrDefault(r => r.RoomNumber == g.RoomNumber);
                        return new
                        {
                            g.GuestName,
                            g.RoomNumber,
                            TotalCost = g.CalculateTotalCost(room.PricePerNight)
                        };
                    })
                    .OrderByDescending(x => x.TotalCost)
                    .Take(1)
                    .ToList();

                var top = ranked.First();
                Console.WriteLine("Highest-revenue booking:");
                Console.WriteLine($"Guest Name  : {top.GuestName}");
                Console.WriteLine($"Room Number : {top.RoomNumber}");
                Console.WriteLine($"Total Cost  : OMR {top.TotalCost:F2}");
            }

            // Case 15 Guest Pagination Viewer 
            static void GuestPaginationViewer()
            {
                const int pageSize = 3;
                Console.Write("Enter page number: ");
                string input = Console.ReadLine()?.Trim();
                if (!int.TryParse(input, out int page) || page <= 0)
                {
                    Console.WriteLine("That page does not exist.");
                    return;
                }
                int totalGuests = guests.Count;
                int totalPages = (totalGuests + pageSize - 1) / pageSize;
                if (!guests.Any())
                {
                    Console.WriteLine("No guests have been registered yet.");
                    return;
                }

                if (page > totalPages)
                {
                    Console.WriteLine("That page does not exist.");
                    return;
                }
                var pageGuests = guests.OrderBy(g => g.GuestName).Skip((page - 1) * pageSize).Take(pageSize).ToList();
                Console.WriteLine($"========== Page {page} of {totalPages} ==========");
                foreach (var g in pageGuests)
                {
                    Console.WriteLine($"Guest ID: {g.GuestId} | Name: {g.GuestName} | Room: {g.RoomNumber}");
                }
            }
        }
    }
}
