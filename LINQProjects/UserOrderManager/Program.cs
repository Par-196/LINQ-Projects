using System;
using System.Collections.Generic;
using System.Linq;
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

                new User { Id = 11, Name = "Alexander", Age = 28 },
                new User { Id = 12, Name = "Charlotte", Age = 24 },
                new User { Id = 13, Name = "Benjamin", Age = 33 },
                new User { Id = 14, Name = "Amelia", Age = 15 },
                new User { Id = 15, Name = "Lucas", Age = 37 },
                new User { Id = 16, Name = "Harper", Age = 12 },
                new User { Id = 17, Name = "Henry", Age = 32 },
                new User { Id = 18, Name = "Evelyn", Age = 20 },
                new User { Id = 19, Name = "Sebastian", Age = 41 },
                new User { Id = 20, Name = "Abigail", Age = 9 }
            };
            List<Order> ordersList = new()
            {
                new Order { Id = 1, UserId = 1, Price = 120.50m },
                new Order { Id = 2, UserId = 1, Price = 89.99m },
                new Order { Id = 3, UserId = 2, Price = 540.00m },
                new Order { Id = 4, UserId = 3, Price = 75.25m },
                new Order { Id = 5, UserId = 3, Price = 300.00m },
                new Order { Id = 6, UserId = 4, Price = 45.90m },
                new Order { Id = 7, UserId = 5, Price = 999.99m },
                new Order { Id = 8, UserId = 5, Price = 150.00m },
                new Order { Id = 9, UserId = 6, Price = 15.99m },
                new Order { Id = 10, UserId = 7, Price = 220.00m },

                new Order { Id = 11, UserId = 8, Price = 87.45m },
                new Order { Id = 12, UserId = 8, Price = 410.10m },
                new Order { Id = 13, UserId = 9, Price = 1200.00m },
                new Order { Id = 14, UserId = 10, Price = 33.33m },
                new Order { Id = 15, UserId = 11, Price = 77.77m },
                new Order { Id = 16, UserId = 12, Price = 555.55m },
                new Order { Id = 17, UserId = 13, Price = 92.10m },
                new Order { Id = 18, UserId = 13, Price = 48.00m },
                new Order { Id = 19, UserId = 14, Price = 670.45m },
                new Order { Id = 20, UserId = 15, Price = 19.99m },

                new Order { Id = 20, UserId = 15, Price = 19.99m },
                new Order { Id = 21, UserId = 16, Price = 250.00m },
                new Order { Id = 22, UserId = 17, Price = 80.80m },
                new Order { Id = 23, UserId = 18, Price = 145.30m },
                new Order { Id = 24, UserId = 19, Price = 9999.99m },
                new Order { Id = 25, UserId = 20, Price = 500.00m }
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
                            var usersOlderThan18 =
                                from user in usersList
                                where user.Age > 18
                                select user;
                            foreach (var user in usersOlderThan18)
                            {
                                Console.WriteLine($"{user}");
                            }
                        }
                        break;
                    case MainMenu.SortUsersByAgeAscending:
                        {
                            var usersByAgeAscending =
                                from user in usersList
                                orderby user.Age ascending
                                select user;
                            foreach (var user in usersByAgeAscending)
                            {
                                Console.WriteLine($"{user}");
                            }
                        }
                        break;
                    case MainMenu.SortUsersByAgeDescending:
                        {
                            var usersByAgeDescending =
                                from user in usersList
                                orderby user.Age descending
                                select user;
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
                            var usersAndOrders =
                                from user in usersList
                                join order in ordersList
                                on user.Id equals order.UserId
                                select new
                                {
                                    user.Name, order.Price
                                };
                            foreach (var item in usersAndOrders)
                            {
                                Console.WriteLine($"Name - {item.Name,-12}\tPrice - {item.Price,-10}");
                            }
                        }
                        break;
                    case MainMenu.GroupUsersByAge:
                        break;
                    case MainMenu.ListOfOrdersForEachUser:
                        break;
                    case MainMenu.UsersInReverseOrder:
                        break;
                    case MainMenu.CheckIfAllUsersAreOlderThan18:
                        break;
                    case MainMenu.CheckIfThereIsAtLeastOneUserYoungerThan18:
                        break;
                    case MainMenu.CheckIfIdListContains5:
                        break;
                    case MainMenu.RemoveDuplicatesFromNameList:
                        break;
                    case MainMenu.GetCommonElementsFromTwoLists:
                        break;
                    case MainMenu.CountUsersOlderThan18:
                        break;
                    case MainMenu.SumOfAllOrders:
                        break;
                    case MainMenu.AverageOrderPrice:
                        break;
                    case MainMenu.MinimumAge:
                        break;
                    case MainMenu.MaximumOrderPrice:
                        break;
                    case MainMenu.PaginationTakeFirst5:
                        break;
                    case MainMenu.PaginationSkip5AndTakeNext5:
                        break;
                    case MainMenu.TakeFromSortedListWhileAgeLessThan30:
                        break;
                    case MainMenu.SkipFromSortedListWhileAgeLessThan30:
                        break;
                    case MainMenu.FirstUserOlderThan18:
                        break;
                    case MainMenu.UserWithId1:
                        break;
                    case MainMenu.ThirdElementInTheList:
                        break;
                    case MainMenu.LastUserOlderThan18:
                        break;
                    case MainMenu.BonusTop3UsersByTotalOrderAmount:
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
