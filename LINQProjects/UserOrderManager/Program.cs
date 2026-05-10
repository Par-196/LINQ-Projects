using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using UserOrderManager.Enums;
using UserOrderManager.Models;

namespace UserOrderManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<User> usersList = new()
            {
                new User { Id = 1, Name = "John", Age = 20 },
                new User { Id = 2, Name = "Emma", Age = 20 },
                new User { Id = 3, Name = "Michael", Age = 30 },
                new User { Id = 4, Name = "Sophia", Age = 17 },
                new User { Id = 5, Name = "Daniel", Age = 35 },
                new User { Id = 6, Name = "Olivia", Age = 20 },
                new User { Id = 7, Name = "James", Age = 29 },
                new User { Id = 8, Name = "Isabella", Age = 31 },
                new User { Id = 9, Name = "William", Age = 40 },
                new User { Id = 10, Name = "Mia", Age = 19 },

                new User { Id = 11, Name = "Alexander", Age = 18 },
                new User { Id = 12, Name = "Charlotte", Age = 24 },
                new User { Id = 13, Name = "Benjamin", Age = 33 },
                new User { Id = 14, Name = "Amelia", Age = 15 },
                new User { Id = 15, Name = "Lucas", Age = 37 },
                new User { Id = 16, Name = "Harper", Age = 12 },
                new User { Id = 17, Name = "Henry", Age = 32 },
                new User { Id = 18, Name = "Evelyn", Age = 20 },
                new User { Id = 19, Name = "Sebastian", Age = 18 },
                new User { Id = 20, Name = "Abigail", Age = 9 }
            };
            List<Order> ordersList = new()
            {
                new Order { Id = 1, UserId = 1, ProductName = "Keyboard", Price = 120.50m },
                new Order { Id = 2, UserId = 1, ProductName = "Mouse", Price = 89.99m },
                new Order { Id = 3, UserId = 2, ProductName = "Monitor", Price = 540.00m },
                new Order { Id = 4, UserId = 3, ProductName = "USB Cable", Price = 75.25m },
                new Order { Id = 5, UserId = 3, ProductName = "Headphones", Price = 300.00m },
                new Order { Id = 6, UserId = 4, ProductName = "Mouse Pad", Price = 45.90m },
                new Order { Id = 7, UserId = 5, ProductName = "Laptop", Price = 999.99m },
                new Order { Id = 8, UserId = 5, ProductName = "Webcam", Price = 150.00m },
                new Order { Id = 9, UserId = 6, ProductName = "Flash Drive", Price = 15.99m },
                new Order { Id = 10, UserId = 7, ProductName = "Microphone", Price = 220.00m },

                new Order { Id = 11, UserId = 8, ProductName = "Chair", Price = 87.45m },
                new Order { Id = 12, UserId = 8, ProductName = "Desk", Price = 410.10m },
                new Order { Id = 13, UserId = 9, ProductName = "Gaming PC", Price = 1200.00m },
                new Order { Id = 14, UserId = 10, ProductName = "Phone Case", Price = 33.33m },
                new Order { Id = 15, UserId = 11, ProductName = "Speaker", Price = 77.77m },
                new Order { Id = 16, UserId = 12, ProductName = "Tablet", Price = 555.55m },
                new Order { Id = 17, UserId = 13, ProductName = "Notebook", Price = 92.10m },
                new Order { Id = 18, UserId = 13, ProductName = "Pen Set", Price = 48.00m },
                new Order { Id = 19, UserId = 14, ProductName = "Smart Watch", Price = 670.45m },

                new Order { Id = 20, UserId = 15, ProductName = "Coffee Mug", Price = 19.99m },
                new Order { Id = 21, UserId = 16, ProductName = "Router", Price = 250.00m },
                new Order { Id = 22, UserId = 17, ProductName = "SSD", Price = 80.80m },
                new Order { Id = 23, UserId = 18, ProductName = "Backpack", Price = 145.30m },
                new Order { Id = 24, UserId = 19, ProductName = "TV", Price = 9999.99m },
                new Order { Id = 25, UserId = 20, ProductName = "Printer", Price = 500.00m }
            };

            bool exit = false;

            while (!exit)
            {
                Console.Clear();
                Console.WriteLine(
                    "1. List of users older than 18\n" +
                    "2. Sort users by age ↑\n" +
                    "3. Sort users by age ↓\n" +
                    "4. Sort by age, and by name if ages are equal\n" +
                    "5. Join Users and Orders: UserName + Order.Price\n" +
                    "6. Group users by age\n" +
                    "7. List of orders for each user\n" +
                    "8. Users in reverse order\n" +
                    "9. Check: are all users older than 18?\n" +
                    "10. Check: is there at least one user younger than 18?\n" +
                    "11. Check if ID list contains 5\n" +
                    "12. Remove duplicates from name list\n" +
                    "13. Get common elements from two lists\n" +
                    "14. Count users older than 18\n" +
                    "15. Sum of all orders\n" +
                    "16. Average order price\n" +
                    "17. Minimum age\n" +
                    "18. Maximum order price\n" +
                    "19. Pagination: take first 5\n" +
                    "20. Pagination: skip 5 and take next 5\n" +
                    "21. Take from sorted list while Age < 30\n" +
                    "22. Skip from sorted list while Age < 30\n" +
                    "23. First user older than 18\n" +
                    "24. User with Id = 1\n" +
                    "25. Third element in the list\n" +
                    "26. Last user older than 18\n" +
                    "27. Bonus: top 3 users by total order amount\n" +
                    "28. Exit"
                );

                Enum.TryParse(Console.ReadLine(), out MainMenu mainMenu);

                Console.Clear();

                switch (mainMenu)
                {
                    case MainMenu.ListOfUsersOlderThan18:
                        {
                            var usersOlderThan18 = usersList
                                .Where(x => x.Age > 18);
                            
                            foreach (var user in usersOlderThan18)
                            {
                                Console.WriteLine($"{user}");
                            }
                        }
                        break;
                    case MainMenu.SortUsersByAgeAscending:
                        {
                            var usersByAgeAscending = usersList
                                .OrderBy(x => x.Age);
                            foreach (var user in usersByAgeAscending)
                            {
                                Console.WriteLine($"{user}");
                            }
                        }
                        break;
                    case MainMenu.SortUsersByAgeDescending:
                        {
                            var usersByAgeDescending = usersList
                                .OrderByDescending(x => x.Age);
                            foreach (var user in usersByAgeDescending)
                            {
                                Console.WriteLine($"{user}");
                            }
                        }
                        break;
                    case MainMenu.SortByAgeAndNameIfAgesAreEqual:
                        {
                            var userByAgeAndName = usersList
                                .OrderBy(x => x.Age)
                                .ThenBy(x => x.Name);
                            foreach (var user in userByAgeAndName)
                            {
                                Console.WriteLine($"{user}");
                            }
                        }
                        break;
                    case MainMenu.JoinUsersAndOrdersUserNameAndOrderPrice:
                        {
                            var usersAndOrders = usersList
                                .Join(ordersList, user => user.Id, order => order.UserId, (user, order) => new { user.Name, order.Price});



                            foreach (var item in usersAndOrders)
                            {
                                Console.WriteLine($"Name - {item.Name,-12}\tPrice - {item.Price,-10}");
                            }
                        }
                        break;
                    case MainMenu.GroupUsersByAge:
                        {
                            var result = usersList
                                .GroupBy(x => x.Age, x => x.Name)
                                .Select(x => new
                                {
                                    Age = x.Key,
                                    Names = x.ToList()
                                });
                            foreach (var user in result)
                            {
                                Console.WriteLine(
                                    $"Age: {user.Age} -> {string.Join(", ", user.Names)}"
                                );
                            }
                        }
                        break;
                    case MainMenu.ListOfOrdersForEachUser:
                        {
                            var result = usersList
                                .Select(user => new
                                {
                                    User = user,
                                    Orders = ordersList.Where(order => order.UserId == user.Id)
                                });
                            foreach (var item in result)
                            {
                                foreach (var orderItem in item.Orders)
                                {
                                    Console.WriteLine($"{item.User.Name,-10} {orderItem.ProductName}");
                                }
                                
                            }
                        }
                        break;
                    case MainMenu.UsersInReverseOrder:
                        {
                            var result = usersList.AsEnumerable().Reverse();
                            foreach (var item in result)
                            {
                                Console.WriteLine($"{item.ToString()}");
                            }
                        }
                        break;
                    case MainMenu.CheckIfAllUsersAreOlderThan18:
                        {
                            var result = usersList.All(x => x.Age > 18);
                            Console.WriteLine(result);
                        }
                        break;
                    case MainMenu.CheckIfThereIsAtLeastOneUserYoungerThan18:
                        {
                            var result = usersList.Any(x => x.Age > 18);
                            Console.WriteLine(result);
                        }
                        break;
                    case MainMenu.CheckIfIdListContains5:
                        {
                            var result = ordersList.Select(x => x.Id).Contains(5);
                            Console.WriteLine(result);
                        }
                        break;
                    case MainMenu.RemoveDuplicatesFromNameList:
                        {
                            var result = usersList.DistinctBy(x => x.Name);
                            foreach (var item in result)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;
                    case MainMenu.GetCommonElementsFromTwoLists:
                        {
                            var result = usersList
                                .Join(ordersList, user => user.Id, order => order.UserId, (user, order) => new 
                                {
                                    user.Id,
                                    user.Name,
                                    order.UserId,
                                    order.ProductName
                                });
                            foreach (var item in result)
                            {
                                Console.WriteLine($"{item.Id,-5}{item.Name,-12}{item.UserId,-5}{item.ProductName,-20}");
                            }   
                        }
                        break;
                    case MainMenu.CountUsersOlderThan18:
                        {
                            var result = usersList.Where(x => x.Age > 18).Count();
                            Console.WriteLine($"Count Users Older Than 18 - {result}");
                        }
                        break;
                    case MainMenu.SumOfAllOrders:
                        { 
                            var result = ordersList.Sum(x => x.Price);
                            Console.WriteLine($"Sum Of All Orders - {result}");
                        }
                        break;
                    case MainMenu.AverageOrderPrice:
                        {
                            var result = ordersList.Average(x => x.Price);
                            Console.WriteLine($"Average Order Price - {result}");
                        }
                        break;
                    case MainMenu.MinimumAge:
                        {
                            var result = usersList.Min(x => x.Age);
                            Console.WriteLine($"Minimum Age - {result}");
                        }
                        break;
                    case MainMenu.MaximumOrderPrice:
                        {
                            var result = ordersList.Max(x => x.Price);
                            Console.WriteLine($"Maximum Order Price - {result}");
                        }
                        break;
                    case MainMenu.PaginationTakeFirst5:
                        { 
                            var result = usersList.Take(5);
                            foreach (var item in result)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;
                    case MainMenu.PaginationSkip5AndTakeNext5:
                        {
                            var result = usersList.Take(5..10);
                            foreach (var item in result)
                            {
                                Console.WriteLine(item);
                            }
                        }
                        break;
                    case MainMenu.TakeFromSortedListWhileAgeLessThan30:
                        {
                            var result = usersList.OrderBy(x => x.Age).TakeWhile(x => x.Age <= 30);
                            foreach (var item in result)
                            {
                                Console.WriteLine(item.Age);
                            }
                        }
                        break;
                    case MainMenu.SkipFromSortedListWhileAgeLessThan30:
                        {
                            var result = usersList.OrderBy(x => x.Age).SkipWhile(x => x.Age <= 30);
                            foreach (var item in result)
                            {
                                Console.WriteLine(item.Age);
                            }
                        }
                        break;
                    case MainMenu.FirstUserOlderThan18:
                        {
                            var result = usersList.FirstOrDefault(x => x.Age == 18);
                            Console.WriteLine(result);
                        }
                        break;
                    case MainMenu.UserWithId1:
                        { 
                            var result = usersList.Single(x => x.Id == 1);
                            Console.WriteLine(result);
                        }
                        break;
                    case MainMenu.ThirdElementInTheList:
                        {
                            var result = usersList.ElementAtOrDefault(2);
                            Console.WriteLine(result);
                        }
                        break;
                    case MainMenu.LastUserOlderThan18:
                        {
                            var result = usersList.LastOrDefault(x => x.Age == 18);
                            Console.WriteLine(result);
                        }
                        break;
                    case MainMenu.BonusTop3UsersByTotalOrderAmount:
                        {
                            var result = usersList.Select(user => new
                            {
                                User = user,
                                ProductName = ordersList.Where(order => order.UserId == user.Id).Select(order => order.ProductName),
                                TotalPrice = ordersList.Where(order => order.UserId == user.Id).Sum(order => order.Price)
                            }).OrderByDescending(x => x.TotalPrice).Take(3);

                            foreach (var item in result)
                            {
                                Console.WriteLine($"Name: {item.User.Name,-12} | ProductName: {string.Join(", ", item.ProductName),-30} | Price: {item.TotalPrice,-10:C}");
                            }
                        }
                        break;
                    case MainMenu.Exit:
                        { 
                            exit = true;
                            Console.WriteLine("You are out");
                        }
                        break;
                }
                Console.Write("\n\nPress Enter to continue");
                Console.ReadLine();
            }




        }
    }
}
