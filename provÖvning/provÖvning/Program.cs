using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace provÖvning
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Ange cirkelns radie: ");
            
            double radie = double.Parse(Console.ReadLine());

            Console.WriteLine("Area: " + Area(radie));
            Console.WriteLine("Omkrets: " + Omkrets(radie));

            Console.ReadKey();
        }
        static double Area(double radie)
        {
            double area = Math.Round((radie * radie * Math.PI),2); 
            return area;
        }

        static double Omkrets(double radie)
        {
            double omkrets = Math.Round((radie * 2 * Math.PI), 2);
            return omkrets;
        }
    }
}
