using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Order
    {
        public DateTime Date { get; set; }

        public string Name { get; set; }
      
        public int Price { get; set; }
        public Order(DateTime date, int price)
        {
            Date = date;
            Price = price;
        }
        public Order()
        {

        }
    }

}
