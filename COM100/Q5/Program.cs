using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose Pine, Oak or Mahogany");
            Console.WriteLine("press 1 to choose Pine, press 2 to choose Oak and press 3 to choose Mahogany");
            int table;
            int pine, oak, mahogany;
            pine = 100;
            oak = 225;
            mahogany = 310;
            table = Convert.ToInt32(Console.ReadLine());


            switch (table)
            {
                case 1:
                    Console.WriteLine($"Pine tables cost {pine:C}");
                    break;
                case 2:
                    Console.WriteLine($"Oak tables cost {oak:C}");
                    break;
                case 3:
                    Console.WriteLine($"Mahogany tables cost {mahogany:C}");
                    break;
                default:
                    Console.WriteLine("Input Error");
                    break;
            }
            
        }
    }
}
