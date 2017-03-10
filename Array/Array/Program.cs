using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            /*
            string[] namn = new string[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Namn nr " + (i + 1) + ":");
                namn[i] = Console.ReadLine();
            }

            for (int i = 0; i < namn.Length; i++)
            {
                Console.WriteLine("namn nr " + (i + 1) + ":" + namn[i]);
            }
            */

            //Övning 2
            /*
            int[] tal = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Tal nr " + (i + 1) + ":");
                tal[i] = int.Parse(Console.ReadLine());
            }

            for (int i = tal.Length-1; i >= 0; i--)
            {
                Console.WriteLine("Tal nr " + (i + 1) + ":" + tal[i]);
            }
            */


            //Övning 3

            int[] numbArray = { 12, 5, 6, 1, 2, 3, -2, -7, 0 };

            for (int i = 0; i < numbArray.Length; i++)
            {
                
            }
            Console.ReadKey();
        }
    }
}
