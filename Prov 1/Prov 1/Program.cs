/*
 * prov 1
    tobias de vall 
    25 November 2016

*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prov_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Uppgift 4
            
            double[] längdOchVikt = new double[10];
            int räknare = 0;
            double medelVikt = 0;
            double medelLängd = 0;
            
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Skriv in längd på person nr " + (i + 1));
                längdOchVikt[räknare] = double.Parse(Console.ReadLine());
                räknare = räknare + 1;
                Console.WriteLine("Skriv in vikt på person nr " + (i + 1));
                längdOchVikt[räknare] = double.Parse(Console.ReadLine());
                räknare = räknare + 1;
                
           }
     
            
                medelLängd = längdOchVikt[0] + längdOchVikt[2] + längdOchVikt[4] + längdOchVikt[6] + längdOchVikt[8];
                medelVikt = längdOchVikt[1] + längdOchVikt[3] + längdOchVikt[5] + längdOchVikt[7] + längdOchVikt[9];

            medelLängd = medelLängd / 5;
            medelVikt = medelVikt / 5;

            medelLängd = Math.Round(medelLängd, 2);
            medelVikt = Math.Round(medelVikt, 2);

            Console.WriteLine("Medelvikten: " + medelVikt + "kg");
            Console.WriteLine("Medellängd: " + medelLängd + "cm");

            double viktPerson1 = längdOchVikt[1];
            double längdPerson1 = längdOchVikt[0];

            Console.WriteLine("BMI värde person 1:");
            BmiVärde(viktPerson1, längdPerson1);

            Console.ReadKey();
        }
        //Uppgift 5
        static string BmiVärde(double viktPerson1, double längdPerson1)
        {
            string bmiVärdePerson1Text = "";
            double bmiVärdePerson1 = (längdPerson1*längdPerson1) / viktPerson1;

            if (bmiVärdePerson1 < 18.5){
                bmiVärdePerson1Text = "undervikt";
            }
            else if (bmiVärdePerson1 > 18.5 && bmiVärdePerson1 < 24.9)
            {
                bmiVärdePerson1Text = "normalvikt";
            }
            else if (bmiVärdePerson1 > 25 && bmiVärdePerson1 < 29.9)
            {
                bmiVärdePerson1Text = "Övervikt";
            }
            else if (bmiVärdePerson1 > 30 && bmiVärdePerson1 < 34.9)
            {
                bmiVärdePerson1Text = "Fetma grad 1";
            }
            else if (bmiVärdePerson1 > 35 && bmiVärdePerson1 < 39.9)
            {
                bmiVärdePerson1Text = "Fetma grad 2";
            }
            else if (bmiVärdePerson1 > 40)
            {
                bmiVärdePerson1Text = "Fetma grad 3";
            }

            return bmiVärdePerson1Text;
        }
    }
}
