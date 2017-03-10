/* 
 * Skapad av Tobias de Vall och Elliot de Wrang
 * 2017/01/27
 * Programmet letar efter den pythagoreiska trippeln där a+b+c=1000
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Övning_6
{
    class Program
    {
        static void Main(string[] args)
        {

            Stopwatch stopwatch = Stopwatch.StartNew(); //creates and start the instance of Stopwatch
                                                        //your sample code

            double a;
            double b;
            double c;
            double c2;
            double total;

            Random rnd = new Random();

            for (int i = 0; true ; i++)
            {
                a = rnd.Next(300);
                b = rnd.Next(400);

                if(b > a)
                {
                    c2 = (a * a) + (b * b);

                    c = Math.Sqrt(c2);

                    total = a + b + c;

                    if (c > b && total == 1000)
                    {
                        Console.WriteLine("a = " + a);
                        Console.WriteLine("b = " + b);
                        Console.WriteLine("c = " + c);
                        Console.WriteLine("Total = " + total);

                        stopwatch.Stop();
                        Console.WriteLine(stopwatch.ElapsedMilliseconds);

                        break;
                    }
                }

            }
            Console.ReadKey();
        }
    }
}
