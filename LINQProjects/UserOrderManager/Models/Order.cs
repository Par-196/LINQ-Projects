using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UserOrderManager.Models
{
    class Order
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public override string ToString()
        {
            return $"| {Id,-3} | {UserId,-6} | {ProductName,-6} |{Price,-10:C} |";
        }
    }
}
