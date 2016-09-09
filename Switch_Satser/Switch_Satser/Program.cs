/*SwitchSatser är övning från Csharpskolan
 * Tobias de Vall den 9 sept 2016
 */




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Switch_Satser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            /*
            Console.WriteLine("Skriv in ett heltal mellan 1 och 4: ");

            int tal = int.Parse(Console.ReadLine());

            switch (tal)
            {
                case 1: Console.WriteLine("Ett");                    break;

                case 2: Console.WriteLine("Två");                    break;

                case 3: Console.WriteLine("Tre");                    break;

                case 4: Console.WriteLine("Fyra");                   break;

                default : Console.WriteLine("Ogiltigt Alernativ!");  break;

            }
            */

            //Övning 2
            /*
            Console.WriteLine("Where do you want to go: ");

            char where = char.Parse(Console.ReadLine());

            switch (where)
            {
                case 'N': Console.WriteLine("You walk north"); break;

                case 'S': Console.WriteLine("You travel south"); break;

                case 'E': Console.WriteLine("You wander east"); break;

                case 'W': Console.WriteLine("You stoll west"); break;

                default: Console.WriteLine("I don't understand"); break;

            }
            */

            //Övning 3

            Console.WriteLine("Mata in det första talet: ");

            int tal1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Mata in det andra talet: ");
            double tal2 = double.Parse(Console.ReadLine());

            Console.WriteLine("Vilket räknesätt vill du använda: ");
            Console.WriteLine("Addition");
            Console.WriteLine("Subtraktion");
            Console.WriteLine("Multiplikation");
            Console.WriteLine("Divition");

            string räknesätt = Console.ReadLine();

            switch (räknesätt)
            {
                case "Addition": Console.WriteLine(tal1 + tal2); break;

                case "Subtraktion": Console.WriteLine(tal1 - tal2); break;

                case "Multiplikation": Console.WriteLine(tal1 * tal2); break;

                case "Divition": Console.WriteLine(tal1 / tal2); break;

            }

            Console.ReadKey();

        }
    }
}
