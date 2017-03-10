using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method
{
    class Program
    {
        //Övning 1
        /*
        static void Main(string[] args)
        {
            double Celsius;

            Console.WriteLine("Mata in grader i Celsius: ");
            Celsius = double.Parse(Console.Read());

            CelsiusTillFarenheit(Celsius);
            Console.WriteLine("Det är " + CelsiusTillFarenheit(Celsius) + " grader Farenheit");

            Console.Read(); 
        }

        static double CelsiusTillFarenheit (double Celsius)
        {
           double Farenheit = (Celsius / 5.0) * 9 + 32;
            return Farenheit;
        }
        */

        //Övning 2
        /*
        static void Main(string[] args)
        {
            double Radie;

            Console.WriteLine("Mata in cirkelns radie: ");
            Radie = double.Parse(Console.ReadLine());

            Area(Radie);
            Omkrets(Radie);

            Console.WriteLine("Area: " + Area(Radie));
            Console.WriteLine("Omkrets: " + Omkrets(Radie));

            Console.Read();
        }

        static double Area(double Radie)
        {
            double Area = Radie * Radie * (Math.PI);
            Area = Math.Round(Area, 2);
            return Area;
        }

        static double Omkrets(double Radie)
        {
            double Omkrets = Radie * 2 * (Math.PI);
            Omkrets = Math.Round(Omkrets, 2);
            return Omkrets;
        }
        */
        static void Main(string[] args)
        {
            Console.WriteLine("Antal tärningskast: ");
            int AntalKast = int.Parse(Console.ReadLine());

            KastaTärning();
        }

        static int KastaTärning(AntalKast)
        {
            return värde; 
        }
    }
}
