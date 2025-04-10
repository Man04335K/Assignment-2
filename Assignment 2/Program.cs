/* 
 * Project Name: LANGHAM Hotel Management System
 * Author Name: Manpreet Kaur
 * Date: 10/4/2025
 * Application Purpose: To manage hotel room allocation, customer records, file storage, and backups with exception handling.
 */

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Assessment2Task2
{
    public class Room
    {
        public int RoomNo { get; set; } // Room number
        public bool IsAllocated { get; set; } // Indicates if the room is allocated
    }

    public class Customer
    {
        public int CustomerNo { get; set; } // Customer number
        public string CustomerName { get; set; } // Customer name
    }

    public class RoomAllocation
    {
        public int AllocatedRoomNo { get; set; } // Allocated room number
        public Customer AllocatedCustomer { get; set; } // Customer details
    }

    class Program
    {
        public static Room[] listofRooms; // Array of rooms
        public static List<RoomAllocation> allocations = new List<RoomAllocation>(); // List of room allocations
        public static string filePath; // File path for saving room allocations

        static void Main(string[] args)
        {
            string folderPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments); // Get the path to the Documents folder
            filePath = Path.Combine(folderPath, "HotelManagement.txt"); // Combine the folder path with the file name

            string ans; // Variable to store user response

            do
            {
                Console.Clear();
                Console.WriteLine("***********************************************************************************");
                Console.WriteLine("                 LANGHAM HOTEL MANAGEMENT SYSTEM                  ");
                Console.WriteLine("                            MENU                                 ");
                Console.WriteLine("***********************************************************************************");
                Console.WriteLine("1. Add Rooms");
                Console.WriteLine("2. Display Rooms");
                Console.WriteLine("3. Allocate Rooms");
                Console.WriteLine("4. De-Allocate Rooms");
                Console.WriteLine("5. Display Room Allocation Details");
                Console.WriteLine("6. Billing");
                Console.WriteLine("7. Save the Room Allocations To a File");
                Console.WriteLine("8. Show the Room Allocations From a File");
                Console.WriteLine("9. Exit");
                Console.WriteLine("0. Backup File");
                Console.WriteLine("***********************************************************************************");
                Console.Write("Enter Your Choice Number Here:");

                try
                {
                    int choice = Convert.ToInt32(Console.ReadLine()); // Read user choice
                    switch (choice) // Switch case to handle user choice
                    {
                        case 1:
                            AddRooms();
                            break;
                        case 2:
                            DisplayRooms();
                            break;
                        case 3:
                            AllocateRoom();
                            break;
                        case 4:
                            DeallocateRoom();
                            break;
                        case 5:
                            DisplayRoomAllocations();
                            break;
                        case 6:
                            Console.WriteLine("Billing Feature is Under Construction and will be added soon…!!!");
                            break;
                        case 7:
                            SaveToFile();
                            break;
                        case 8:
                            ShowFromFile();
                            break;
                        case 9:
                            Console.WriteLine("Thank you for using LANGHAM Hotel Management System.");
                            return;
                        case 0:
                            BackupFile();
                            break;
                        default:
                            Console.WriteLine("Invalid Choice.");
                            break;
                    }
                }
                catch (FormatException) // Catch block to handle format exception
                {
                    Console.WriteLine("Please enter a valid number!");
                }
                catch (OverflowException) // Catch block to handle overflow exception
                {
                    Console.WriteLine("The number entered is too large!");
                }
                catch (Exception ex) // Catch block to handle any other exceptions
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
                finally // Finally block to ensure the program continues
                {
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey(); // Wait for user input before continuing
                }

                Console.Write("\nWould You Like To Continue? (yes/no): ");//
                ans = Console.ReadLine()?.Trim().ToLower();

            } while (ans == "yes");
        }

        // Placeholder methods (to be filled later)
        public static void AddRooms() { }
        public static void DisplayRooms() { }
        public static void AllocateRoom() { }
        public static void DeallocateRoom() { }
        public static void DisplayRoomAllocations() { }
        public static void SaveToFile() { }
        public static void ShowFromFile() { }
        public static void BackupFile() { }
    }
}

/* summary
 * The code above is a basic structure for a hotel management system that includes room allocation, customer records, and file storage.
 * It uses exception handling to manage user input and file operations.
 * The methods for adding rooms, displaying rooms, allocating rooms, deallocating rooms, displaying room allocations, saving to a file, showing from a file, and backing up the file are placeholders and need to be implemented.
 */