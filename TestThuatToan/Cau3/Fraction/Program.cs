using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ft,ft2;
            int a, b, c, d, bc;
            int index;
            Console.WriteLine("nhap phan so dau tien");
            ft= Convert.ToString(Console.ReadLine());
            ft=shortFraction(ft);
            Console.WriteLine("Nhap phan so thu 2");
            ft2= Convert.ToString(Console.ReadLine());
            ft2=shortFraction(ft2);
            a= Tu(ft);
            b= Mau(ft);
            c= Tu(ft2);
            d= Mau(ft2);
            bc = BSCNN(b, d);
            a = a * (bc / b);
            c = c * (bc / d);
            Console.WriteLine("KQ:" + (a+c)+"/"+bc);
            Console.ReadKey();
        }
        static string shortFraction(string n)
        {
            int a;
            int b;
            int tempA;
            a = Tu(n);
            tempA = a;
            b = Mau(n);
            a = a / USCLN(a, b);
            b = b / USCLN(tempA, b);
            return Convert.ToString(a) +"/"+ Convert.ToString(b);
        }
        static int Tu(string a)
        {
            return (Convert.ToInt32( a.Substring(0, a.IndexOf("/"))));

        }
        static int Mau(string a)
        {
            return (Convert.ToInt32( a.Substring(a.IndexOf("/") + 1)));
        }
        static int USCLN(int a, int b)
        {
            if (b == 0) return a;
            return USCLN(b, a % b);
        }
        static int BSCNN(int a, int b)
        {
            return (a * b) / USCLN(a, b);
        }
    }
}
