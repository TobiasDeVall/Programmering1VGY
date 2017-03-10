using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Klasser
{
    class Program
    {
        static void Main(string[] args)
        {
            //Övning 1
            /*
            Bil nyBil = new Bil();

            Console.WriteLine("Ange Bilmärke: ");
            nyBil.Märke = Console.ReadLine();
            Console.WriteLine("Ange Modell: ");
            nyBil.Modell = Console.ReadLine();
            Console.WriteLine("Ange År: ");
            nyBil.År = int.Parse(Console.ReadLine());
            Console.WriteLine("Ange Regesteringsnummer: ");
            nyBil.RegNr = Console.ReadLine();
            Console.WriteLine("Ange Hästkrafter: ");
            nyBil.HästKraft = int.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine("Märke: " + nyBil.Märke);
            Console.WriteLine("Model: " + nyBil.Modell);
            Console.WriteLine("År: " + nyBil.År);
            Console.WriteLine("Hästkrafer: " + nyBil.HästKraft);
            Console.WriteLine("Regestreringsnummer: " + nyBil.RegNr);


            //Övning 2

            Namn nyttNamn = new Namn();

            Console.WriteLine("Ange Förnamn: ");
            nyttNamn.Förnamn = Console.ReadLine();
            Console.WriteLine("Ange Efternamn: ");
            nyttNamn.Efternamn = Console.ReadLine();

            Console.WriteLine("Fullständigt namn: " + nyttNamn.FullständigtNamn);
            */

            //Övning 3
            Datum age = new Datum();

            Console.WriteLine("Födelseår: ");
            age.year = int.Parse(Console.ReadLine());
            Console.WriteLine("Födelsemånad: ");
            age.month = int.Parse(Console.ReadLine());
            Console.WriteLine("Födelsedag: ");
            age.day = int.Parse(Console.ReadLine());


            Console.ReadKey();
        }
    }
}
