using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Longarray
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b;
            a = 0;
            b = 1;
            int count;
            count = 2;
            Console.WriteLine("1: " + a);
            Console.WriteLine("2: " + b);
            while (count <= 98)
            {
                a = a + b;
                count++;
                Console.WriteLine(count + ": " + a + "   ");
                b = a + b;
                count++;
                Console.WriteLine(count + ": " + b + "    ");
            }
            Console.ReadKey();
        }
    }

}

