using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IF_Satser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            /*
            Console.Write("Skriv in mönsterdjup: ");
            double djup = double.Parse(Console.ReadLine());

            if (djup < 1.6)
            {
                Console.WriteLine("Olagliga däck!");
            }

            else
            {
                Console.WriteLine("Lagliga däck!");
            }
            */

            //Övning 2
            /*
            Console.Write("Skriv in ålder: ");
            int ålder = int.Parse(Console.ReadLine());

            if (ålder < 12 && ålder >= 0)
            {
                Console.WriteLine("Vit");
            }

            else if(ålder > 12 && ålder <= 18)
            {
                Console.WriteLine("Grön");
            }

            else if (ålder > 18 && ålder <= 26)
            {
                Console.WriteLine("Röd");
            }

            else if (ålder > 26 && ålder <= 99)
            {
                Console.WriteLine("Blå");
            }

            else
            {
                Console.WriteLine("Ogiltig ålder!");
            }
            */

            //Övning 3
            /*
            Console.Write("Mata in tal: ");
            decimal tal1 = decimal.Parse(Console.ReadLine());

            Console.Write("Mata in tal: ");
            decimal tal2 = decimal.Parse(Console.ReadLine());

            if(tal1 > tal2)
            {
                Console.WriteLine("Tal 1 var störst: " + tal1);
            }

            else if (tal2 > tal1)
            {
                Console.WriteLine("Tal 2 var störst: " + tal2);
            }

            else
            {
                Console.WriteLine("Talen var lika!");
            }
            */

            //Övning 4

            Console.Write("Mata in ett tal: ");
            decimal tal = decimal.Parse(Console.ReadLine());

            tal = tal % 7;

            if(tal == 0)
            {
                Console.WriteLine("Talet är jämt delbart med 7!");
            }

            else
            {
                Console.WriteLine("Talet är inte jämt delbart med 7. Resten blir: " + tal);

            }



            Console.ReadKey();

        }
    }
}
