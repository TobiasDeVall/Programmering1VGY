using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Slump
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            /*
            int medel = 0;

            Console.WriteLine("Programmet slumpar fram 10 tal mellan 1-20 och beräknar medelvärdet");

            Random slump = new Random();

            for (int i = 0; i < 10; i++)
            {
                
                int tal = slump.Next(1, 21);
                medel = medel + tal;

                Console.Write(tal + " ");

            }

            medel = medel / 10;

            Console.Write("medelvärdet blev " + medel);
            */

            //Övning 2
            /*
            Console.WriteLine("Programmet slumpar fram 20 tal mellan 15-30 och beräknar medianvärdet");
            Console.WriteLine("På platsen där medianvärdet beräknas visas ett stolptecken |");

            int[] värde = new int[20];
            Random slump = new Random();

            for (int i = 0; i < 20; i++)
            {
                värde[i] = slump.Next(15, 30);
            }
            Array.Sort(värde);

            for (int i = 0; i < 20; i++)
            {
                Console.Write(värde[i] + " ");

                if (i == 9)
                {
                    Console.Write("| ");
                }
            }
            double median = värde[9] + värde[10];
            Console.Write("Medianen är " + median / 2);
            */

            //Övning 3
            Console.WriteLine("Du ska gissa ett tal som slumpas fram mellan 0 ch 100.");

            Random slump = new Random();
            int tal = slump.Next(100);
            int loop = 0;
            int gissningTal = 0;

            while (loop == 0)
            {
                Console.WriteLine("Vilket är ditt tal?");
                string gissningText = Console.ReadLine();
                gissningTal = int.Parse(gissningText);

                if (gissningTal > tal)
                {
                    Console.WriteLine("För högt gissa igen");
                }
                else if (gissningTal < tal)
                {
                    Console.WriteLine("För lågt Gissa igen");
                }
                else if (gissningTal == tal)
                {
                    Console.WriteLine("Rätt gissat");
                    break;
                }
            }

            Console.ReadKey();
        }
    }
}
