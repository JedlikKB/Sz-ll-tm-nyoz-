using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szallitmanyozo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] teljes = { "ABC-123", "ASD-234", "FGH-432", "BAB-987", "SEX-444" };
            List<string> bent = new List<string>();
            string választás;
            do
            {
                Console.WriteLine("Elmegy (E)");
                Console.WriteLine("Bejön (B)");
                Console.WriteLine("Kilépés (K)");
                választás = Console.ReadLine();
                switch (választás)
                {
                    case "E":Elmegy();
                        break;
                    case "B":Bejön(teljes,bent);
                        break;
                    case "K":Kilépés();
                        break;
                    default: Console.WriteLine("Nem megfelelő választás.");
                        break;
                }
            } while (választás!="K");

            Console.ReadKey();
        }

        private static void Elmegy()
        {
            throw new NotImplementedException();
        }

        private static void Kilépés()
        {
            throw new NotImplementedException();
        }

        private static void Bejön(string[] teljes, List<string> bent)
        {
            string adottrendszám;

            do
            {
                Console.WriteLine("Kérem a rendszámot: ");
                adottrendszám = Console.ReadLine();
                Console.WriteLine("Kilépéshez üssön le egy 'K' betűt.");

                if (bent.Contains(adottrendszám)&&adottrendszám!="K")
                {
                    Console.WriteLine("Ez a rendszám bent van.");
                }
                else if(!bent.Contains(adottrendszám)&&adottrendszám!="K")
                {
                    bent.Add(adottrendszám);
                }

            } while (adottrendszám!="K"||adottrendszám!="k");
        }
    }
}
