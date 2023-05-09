using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double v;
            int check;
            float t, tmax, a, x, y;
            double tempA, tGround;
            Console.WriteLine("Chọn 1 để nhập dữ liệu là độ C");
            Console.WriteLine("Chọn 2 để nhập dữ liệu là Radian");
            check = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap van toc");
            v = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("NHap thoi gian");
            t = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Nhap goc");
            a = Convert.ToInt32(Console.ReadLine());
            if (check == 1) a = (float)((Math.PI / 180) * a);
            tmax = (float)(v * Math.Sin(a) / 10);
            tGround = tmax * 2;
            if (t < tmax)
            {
                x = (float)(v * (Math.Cos(a)) * t);
                y = (float)(v * (Math.Cos(a) * t) - ((10 * t * t) / 2));
            }
            else if ((t > tmax) && (t < tGround)) {
                x = (float)(v * (Math.Cos(a) * tmax));
                y = (float)(v * (Math.Cos(a) * tmax) - ((10 * tmax * tmax) / 2));
            }
            else
            {
                y = 0;
                x = (float)((v * v * (Math.Cos(a)) * (Math.Sin(a))) / (10));
            }
            
    
            Console.WriteLine("("+x+","+y+")");
            Console.ReadKey();
        }
    }
}
