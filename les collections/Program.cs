using System;
using System.Collections.Generic;
using System.Linq;

namespace les_collections
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = { "janvier", "fevrier", "mars", "avril", "mai", "juin", "juillet", "aout", "septembre", "octobre", "novembre", "decembre" };
            List<string> mois = new List<string>(input);
            foreach (var item in mois)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(mois[2]);
            Console.WriteLine(mois[5]);
            mois[7] = "août";
            Console.WriteLine(mois[7]);
            mois.Insert(0, "mois d'année");
            foreach (var item in mois)
            {
                Console.WriteLine(item);
            }
            mois.RemoveAt(3);
            Console.WriteLine(mois.Exists(item => item == "janvier"));
            mois.Sort();
            foreach (var item in mois)
            {
                Console.WriteLine(item);
            }

            List<string> nouveau = mois.ToList();
            foreach (var item in nouveau)
            {
                Console.WriteLine(item);
            }






        }
    }
}
