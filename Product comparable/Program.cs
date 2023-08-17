using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_comparable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product Ac = new Product("Ac", 12000);
            Product Tv = new Product("Tv", 30000);

            int result = Ac.CompareTo(Tv);

            if (result < 0)
            {
                Console.WriteLine("Ac has less price than Tv");
            }
            else if (result > 0)
            {
                Console.WriteLine("Ac has more price than Tv");
            }
            else
            {
                Console.WriteLine("Mobile and Laptop has same price");
            }
        }
    }
}
