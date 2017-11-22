using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    class Program
    {
        public static double ReadNumber()
        {
            double x=0;
            string str;
            bool j;
           do
            {
                j = false;
                str = Console.ReadLine();
            try
            {
                x = double.Parse(str);
              
            }
            catch (Exception e)
            {
                j = true;
                Console.WriteLine("Вы ввели не число, введите значение повторно");
                
            }
        } while (j == true);
            return x;
        }
        static void Main()
        {
            double A, B, C;
            Console.WriteLine("A*x^2+B*x+C=0\nВведите коэффициент A");
            A=ReadNumber();
            Console.WriteLine("Введите коэффициент B");
            B = ReadNumber();
            Console.WriteLine("Введите коэффициент C");
            C = ReadNumber();
            double D = B * B - 4 * A * C;
            double x1, x2;
            Console.WriteLine("D={0}", D);
            if (D==0)
            {
                x1 = -B / 2 / A;
                Console.WriteLine("x1,x2={0}", x1);
                return;
            }
            if (D>0)
            {
                x1 = (-B-Math.Sqrt(D)) / 2 / A;
                x2 = (-B + Math.Sqrt(D)) / 2 / A;
                Console.WriteLine("x1={0}\nx2={1}", x1,x2);
                return;
            }
            if (D < 0)
            {
                x1 = (-B - Math.Sqrt(-D)) / 2 / A;
                x2 = (-B + Math.Sqrt(-D)) / 2 / A;
                Console.WriteLine("x1={0}*i\nx2={1}*i", x1, x2);
                return;
            }

        }
    }
}
