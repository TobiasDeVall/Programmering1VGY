using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace While_Satser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1.1
            /*
            int i = 0;
            while (i++ < 100)
            {
                Console.WriteLine(i);
            }
            */

            //Övning 1.2
            /*
            Console.WriteLine("Password: ");
            string password = Console.ReadLine();

            while (password != "Tobbetheman")
            {
                Console.WriteLine("Wrong Password!");
                password = Console.ReadLine();

            }
            Console.WriteLine("Welcome!");
            */


            //Övning 2.1
            /*
            int i = 0;

            while (i++ < 100)
            {
                Console.WriteLine(i);
            }
            */

            //Övning 2.2
            /*
            int i = 11;

            while (i-- > 1)
            {
                Console.WriteLine(i);
            }
            */

            //Övning 2.3
            /*
            while (true)
            {
                Console.WriteLine("Tobbe is the best!");
            }
            */

            //Övning 2.4
            /*
            Random random = new Random();
            int tal_n = random.Next(0, 101 );
            int gissningar = 0;

            Console.WriteLine("Gissa ett tal mellan 1 och 100: ");
            string text = Console.ReadLine();
            int tal = int.Parse(text);

            while (tal != tal_n)
            {
                if (tal > tal_n)
                {
                    gissningar++;
                    Console.WriteLine("För Högt!");
                    Console.WriteLine("Gissa ett tal mellan 1 och 100: ");
                    text = Console.ReadLine();
                    tal = int.Parse(text);
                }
                else if (tal < tal_n)
                {
                    gissningar++;
                    Console.WriteLine("För Lågt!");
                    Console.WriteLine("Gissa ett tal mellan 1 och 100: ");
                    text = Console.ReadLine();
                    tal = int.Parse(text);
                } 
            }
            Console.WriteLine("Grattis du gissade rätt!");
            Console.WriteLine("Det tog dig {0} gissningar!", gissningar);
            */

            //Övning 2.5
            int fib_1 = 0;
            int fib_2 = 1;
            int fib_n;


            while (fib_1 < 1000)
            {
                fib_1 = fib_1 + fib_2;
                Console.Write("1" + fib_1);

            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
