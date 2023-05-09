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
            bool check = true;
            double number;
            double temp;
            number = Convert.ToDouble(Console.ReadLine());
            if ((number < 1) || (number == 1) || (number == 2))
            {
                Console.WriteLine(number + " la so nguyen to ");
                check = true;
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine(number + " Khong là so nguyen to ");
            }
            else
            {
                temp = Math.Sqrt(number);
                for (int i = 2; i < temp; i++)
                {
                    if (number % i == 0)
                    {
                        Console.WriteLine(number + " khong la so nguyen to ");
                        check = false;
                        Console.WriteLine(i);
                        break;
                    }
                }
            }
            if (check) Console.WriteLine(number + " khong la so nguyen to ");
            Console.ReadKey();

        }
    }

}

