using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OutputTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string inmatat;
            int tal;


            Console.Write("Mata in ett tal: ");
            inmatat = Console.ReadLine();


            tal = int.Parse(inmatat);
            
            Console.WriteLine("Du matade in talet " + inmatat);
            Console.WriteLine("dubbla talet blir " + tal * 2);    

            Console.ReadKey();
        }
    }
}
