using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FOR_Satser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            /*
                for (int i = 0; i <= 100; i++)
                {
                    Console.WriteLine(i);
                }
                */

            //Övning 2
            /*
            for (int i = 20; i > 0; i--)
            {
                Console.WriteLine(i);
            }
            */

            //Övning 3
            /*
            for (int i = 0; i <= 50; i = i + 2)
            {
                Console.WriteLine(i);
            }
            */

            //Övning 4
            /*
            Console.WriteLine("Mata in start: ");
            int start = int.Parse(Console.ReadLine());

            Console.WriteLine("Mata in stop: ");
            int stop = int.Parse(Console.ReadLine());

            Console.WriteLine("Mata in steg: ");
            int steg = int.Parse(Console.ReadLine());

            for (int i = start; i < stop + steg; i = i + steg)
            {
                Console.Write(i + " ");
            }
            */

            //Övning 5
            /*
         int summa = 0;

         Console.Write("Mata in ett heltal: ");

         int heltal = int.Parse(Console.ReadLine());

         for (int i = 0; i <= heltal; i++)
         {
             summa = summa + i;
         }

         Console.Write("Summan av alla tal från 1 till " + heltal + " blir: " + summa);
         */

            //Övning 6
            /*
            Console.Write("Mata in ett heltal: ");

            int heltal = int.Parse(Console.ReadLine());
            int heltal2 = 1;
            int heltal3 = 0;
            int heltal4 = 0;

            for (int i = 0; i <= heltal; i++)
            {
                int modulo1 = heltal2 % 3;
                int modulo2 = heltal2 % 7;


                if (modulo1 == 0 && modulo2 == 0)
                {
                    Console.WriteLine("Talet " + heltal2 + " är jämnt delbart med både 3 och 7");
                    heltal3 = heltal3++;
                }
                if (heltal3 == 0 && heltal4 == 0)
                {
                    Console.WriteLine("Hittade inga tal...");
                    heltal4++;
                }
                heltal2 = heltal2 + 1;

            }
            */

            //Övning 7
            /*
            Console.WriteLine("Ange ett heltal: ");

            int tal = int.Parse(Console.ReadLine());
            int tal0 = 0;
            int tal1 = 1;
            int taln;

            if (tal == 0)
                Console.WriteLine("Fibonaccitalen blir: 0");
            else {
                Console.Write("Fibonaccitalen blir: 1  ");
                for (int i = 1; i < tal; i++)
                {
                    taln = tal0 + tal1;
                    tal0 = tal1;
                    tal1 = taln;
                    Console.Write(taln + "  ");
                }
            }

            Console.WriteLine();
            Console.ReadKey();

            */

            //övning 8

            Console.Write("Ange ett tal: ");

            double tal = double.Parse(Console.ReadLine());
            double tal3 = 0;
            double tal4 = 0;


            for (int i = 0; i < tal; i++)
            {
                tal3 = tal3 + 0.1;

                tal4 = tal3 * tal3 * tal3;

                if ( tal4 == tal)
                {
                    Console.WriteLine(tal3);
                }
            }




            Console.ReadKey();
        }
    }
}
