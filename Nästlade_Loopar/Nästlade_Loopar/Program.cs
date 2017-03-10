using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nästlade_Loopar
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            /*
            for (int i = 0; i < 10; i++)
            {
                for (int x = 0; x < 5; x++)
                {
                    Console.Write("o#");
                }
                Console.WriteLine();
            }
            */

            //Övning 2
            /*
            for (int i = 0; i < 11; i++)
            {
                int iModulo = i % 2;
                if (iModulo == 0)
                {
                    for (int x = 0; x < 5; x++)
                    {
                        Console.Write("o#");
                    }
                    Console.Write("o");
                }
                else if(iModulo != 0)
                {
                    for (int y = 0; y < 5; y++)
                    {
                        Console.Write("#o");
                    }
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            */

            //Övning 3
            /*
            for (int i = 0; i < 10; i++)
            {
                int antalBort = 10 - i;

                for (int x = 0; x < antalBort; x++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
            */

            //Övning 4
            /*
            for (int i = 0; i <= 10; i++)
            {
                int antalBort = 10 - i;

                for (int x = 0; x < antalBort; x++)
                {
                    Console.Write("*");
                }
                
                for (int y = 0; y < i; y++)
                {
                    Console.Write(".");
                }
                Console.WriteLine();
            }
            */

            //Övning 5
            /*
            for (int i = 0; i < 7; i++)
            {
                int teckenEtt = i;
                int teckenTva = 6 - i;
                for (int x = 0; x < 7; x++)
                {
                    if (x == i || x == teckenTva)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }
            */

            //Övning 6

            for (int i = 0; i < 7; i++)
            {
                int teckenEtt = i;
                int teckenTva = 6 - i;
                for (int x = 0; x < 7; x++)
                {
                    if (x == i || x == teckenTva)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
                Console.WriteLine();
            }

            Console.ReadKey();
        }
    }
}
