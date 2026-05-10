using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserOrderManager.Models;

namespace UserOrderManager
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<User> users = new()
            {
                new User { Id = 1, Name = "John", Age = 21 },
                new User { Id = 2, Name = "Emma", Age = 25 },
                new User { Id = 3, Name = "Michael", Age = 30 },
                new User { Id = 4, Name = "Sophia", Age = 27 },
                new User { Id = 5, Name = "Daniel", Age = 35 },
                new User { Id = 6, Name = "Olivia", Age = 22 },
                new User { Id = 7, Name = "James", Age = 29 },
                new User { Id = 8, Name = "Isabella", Age = 31 },
                new User { Id = 9, Name = "William", Age = 40 },
                new User { Id = 10, Name = "Mia", Age = 19 },

                new User { Id = 11, Name = "Alexander", Age = 28 },
                new User { Id = 12, Name = "Charlotte", Age = 24 },
                new User { Id = 13, Name = "Benjamin", Age = 33 },
                new User { Id = 14, Name = "Amelia", Age = 26 },
                new User { Id = 15, Name = "Lucas", Age = 37 },
                new User { Id = 16, Name = "Harper", Age = 23 },
                new User { Id = 17, Name = "Henry", Age = 32 },
                new User { Id = 18, Name = "Evelyn", Age = 20 },
                new User { Id = 19, Name = "Sebastian", Age = 41 },
                new User { Id = 20, Name = "Abigail", Age = 34 }
            };
            List<Order> orders = new()
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











        }
    }
}
