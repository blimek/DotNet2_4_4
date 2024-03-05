using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet2_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x;
            string y;
            float z;

            x = 10;
            y = "Szkoła Dotneta";
            z = 10.5f;

            Console.WriteLine($" {x}, {y}, {z}");
            Console.ReadLine();
        }
    }
}
