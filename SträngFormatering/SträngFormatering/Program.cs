using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SträngFormatering
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            /*
            Console.WriteLine("{0,10:d}",DateTime.Now);
            */

            //Övning 2
            /*
            int radie = 4;
            double piNumber = Math.PI;
            double area = radie * radie * piNumber;

            Console.WriteLine(area.ToString("F4"));
            */

            //Övning 3
            /*
            Console.WriteLine("{0:0,0}", 1000000000);
            */

            //Övning 4
            /*
            double value = 123.00;

            value = value * 100;

            Console.WriteLine("Det blir ### {0:## och ##} öre ###", value);
            */

            //Övning 5
            /*
            Console.WriteLine("Mata in ditt Personnummer:");

            string personNummerText = Console.ReadLine();
            long personNummer = long.Parse(personNummerText);

            Console.WriteLine("{0:#### ## ##-####}", personNummer);
            */

            //Övning 6

            const string myFormat = "{0,-10} | {1,-10} | {2,-10} | {3,-10} | {4,-20}";

            Console.WriteLine("-----------------------VeckoSchema--------------------");
            Console.WriteLine("Måndag     | Tisdag     | Onsdag     | Torsdag    | Fredag    ");
            Console.WriteLine("------------------------------------------------------");

            Console.WriteLine(String.Format(myFormat, "Matematik", "Engelska", "Teknik", "Idrott", "Programmering"));
            Console.WriteLine(String.Format(myFormat, "Svenska", "Historia", "Matematik", "Matematik", "Webbprogrammering"));

            Console.ReadLine();
        }
    }
}
