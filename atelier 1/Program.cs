using System;

namespace atelier_1
{
    class Program
    {
        static void Main(string[] args)
        {
            double pHT;
            double tva;
            double pttc;

            Console.WriteLine("Veuillez saisir un produit");
            string pdt = Console.ReadLine();

            Console.WriteLine("Veuillez saisir un prix hors taxe");
            pHT = (double.Parse(Console.ReadLine()));
            Console.WriteLine(" ");

            Console.WriteLine("Veuillez saisir le taux de la TVA: ");
            tva = (double.Parse(Console.ReadLine()));
            Console.WriteLine(" ");

            pttc = pHT * (1+ (tva/100));
            Console.WriteLine(" Le prix total est de: " + pttc);
            Console.WriteLine(" ");



        }
    }
}

