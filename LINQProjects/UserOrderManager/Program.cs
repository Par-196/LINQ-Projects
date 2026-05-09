using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserOrderManager
{
    internal class Program
    {
        class ProductInfo
        {
            public string Name { get; set; } = "";
            public string Description { get; set; } = "";
            public int NumberInStock { get; set; } = 0;

            public override string ToString()
                => $"Name={Name}, Description={Description}, Number in Stock={NumberInStock}";
        }
        static void Main(string[] args)
        {

            ProductInfo[] itemsInStock = new[] {
                new ProductInfo{ Name = "Mac's Coffee", Description = "Coffee with TEETH", NumberInStock = 24},

                new ProductInfo{ Name = "Milk Maid Milk", Description = "Milk cow's love", NumberInStock = 100},

                new ProductInfo{ Name = "Pure Silk Tofu", Description = "Bland as Possible", NumberInStock = 120},

                new ProductInfo{ Name = "Crunchy Pops", Description = "Cheezy, peppery goodness", NumberInStock = 2},

                new ProductInfo{ Name = "RipOff Water", Description = "From the tap to your wallet", NumberInStock = 100},

                new ProductInfo{ Name = "Classic Valpo Pizza", Description = "Everyone loves pizza!", NumberInStock = 73}
            };


            for (int i = 0; i < itemsInStock.Length; i += 2)
            {
                var chunk = itemsInStock.Chunk(size: 2);

                Console.WriteLine("NEW CHUNK");

                foreach (var item in chunk)
                {
                    Console.WriteLine(item.Name);
                }
                Console.ReadLine();
            }
        }
    }
}
