using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqProduct
{
    class Product
    {
        public string Name { get; set; }
        public int Price { get; set; }

        public override string ToString()
        {
            return Name + " : " + Price + "원";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>()
            {
                new Product(){Name="고구마", Price=1500},
                new Product(){Name="사과", Price=2000},
                new Product(){Name="배", Price=2500},
                new Product(){Name="양배추", Price=3000},
                new Product(){Name="옥수수", Price=2000},
                new Product(){Name="자두", Price=500}
            };

            var output = from p in products
                         where p.Price > 1500
                         orderby p.Name ascending
                         select p;

            foreach(var p in output)
            {
                Console.WriteLine(p);
            }

        }
    }
}
