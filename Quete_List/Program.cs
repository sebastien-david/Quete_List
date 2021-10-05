using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quete_List
{
    class Program
    {
        static void Main(string[] args)
        {
            string sautLigne = "\n--------------------\n";
            List<string> grandeSoif = new List<string>();
            grandeSoif.Add(" Bière");
            grandeSoif.Add(" bien");
            grandeSoif.Add(" fraîche");

            foreach (string aBoire in grandeSoif)
            {
                Console.WriteLine(aBoire);
            }

            Console.WriteLine(sautLigne);

            grandeSoif.RemoveAt(0);

            foreach (string aBoire in grandeSoif)
            {
                Console.WriteLine(aBoire);
            }

            Console.WriteLine(sautLigne);

            grandeSoif.Remove(" fraîche");

            foreach (string aBoire in grandeSoif)
            {
                Console.WriteLine(aBoire);
            }

            Console.WriteLine(sautLigne);

            grandeSoif[0] = " J'ai tout bu !";

            string toutBu = grandeSoif[0];
            Console.WriteLine(toutBu);

            Console.ReadLine();
        }

    }
}
