using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //在集合中移除多個項目
            List<Product> Product = new List<Product>()
            {
            new Product(){Name="1",Price=1},
            new Product(){Name="2",Price=2},
            new Product(){Name="3",Price=3},

            };

            Product.Remove(Product[0]);
           

        }
    }
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }
    }

}
