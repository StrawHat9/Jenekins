using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 0;
            while (a == 0)
            {
                Console.WriteLine("Enter 1st number");
                a = Convert.ToInt32(Console.ReadLine());
            }
            while (b == 0)
            {
                Console.WriteLine("Enter 2nd number");
                b = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine(a + b);
            Console.WriteLine(a * b);
            Console.ReadLine();
        }
    }
}
