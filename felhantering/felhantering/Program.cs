using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace felhantering
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            bool inBool = false;
            int inkomst = 0;
            int timmar = 0;

            do
            {
                try
                {
                    Console.Write("Ange din inkomst: ");
                    inkomst = int.Parse(Console.ReadLine());
                    break;
                }
                catch(OverflowException e)
                {
                    Console.WriteLine("Skriv ett mindre tal!");
                }
                catch (FormatException e)
                {
                    Console.WriteLine("Skriv ett tal!");
                }
                catch (ArgumentNullException e)
                {
                    Console.WriteLine("Skriv ett tal!");
                }


            } while (!inBool);

            Console.Write("Ange antal timmar: ");
            timmar = int.Parse(Console.ReadLine());

            Console.WriteLine("Din timlön blev: " + (inkomst / timmar) + " kr/h");

            Console.ReadKey();

        }
    }
}
