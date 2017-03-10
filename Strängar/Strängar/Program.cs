using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strängar
{
    class Program
    {
        static void Main(string[] args)
        {

            //Övning 1
            /*
            Console.WriteLine("\u0056\u00e4\u0157\u006d\u0064\u00f6\u0020\u0047\u0079\u006d\u006e\u0061\u0073\u0069\u0075\u006d");
            */

            //Övning 2
            /*
            Console.WriteLine("\"Hello World\"");
            */

            //Övning 3
            /*
            string str = "Hello World";

            string ver = str.ToUpper();
            string gem = str.ToLower();

            Console.WriteLine(ver);

            Console.WriteLine(gem);
            */

            //Övning 4
            /*
            string str = "Hello World";

            Console.WriteLine("Hello World innehåller " + str.Length + " tecken");

            */

            //Övning 5
            /*
            Console.WriteLine("Skriv in en text:");

            string inmatat = Console.ReadLine();

            char[] inmatatArray = inmatat.ToCharArray();

            for (int i = inmatat.Length - 1; i >= 0 ; i--)
            {
                Console.Write(inmatat[i]);
            }
            */

            //Övning 6

            string textMedParam = "{0} elefant{1} balanserade på en liten liten spindeltråååd.\n"
                                  + "Det tyckte {2} var så intressant, \n"
                                  + "{3}";
                                  

            string finalText = string.Format(textMedParam, "En", "", "han");

            Console.WriteLine(finalText);

            for (int i = 1; i < 10; i++)
            {
                
                if (i == 10)
                {
                    finalText = string.Format(textMedParam, ++i, "er", "de", );
                }
                finalText = string.Format(textMedParam, ++i, "er", "de");
                Console.WriteLine(finalText);

            }



            Console.ReadKey();
        }
    }
}
