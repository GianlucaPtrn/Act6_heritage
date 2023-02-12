using System;

namespace Act6_Heritage_Ex1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Eleve eleve1 = new Eleve("Gianluca", "rue des chardonnerets 47", 5310, "Leuze", "6TTI", "rue des planate");
            Professeur professeur1 = new Professeur("Gorge", "rue des faculte 23", 3423, "leuze", "math");

            Console.WriteLine("__________________________________________");
            Console.WriteLine("Bienvenue dans l'activite 6 sur l'heritage");
            Console.WriteLine("__________________________________________");

            string reload = "oui";
            while (reload == "oui")
            {
                Console.WriteLine("");
                Console.WriteLine(eleve1.FabriqueEtiq());
                Console.WriteLine(professeur1.FabriqueEtiq());
                Console.WriteLine("");

                Console.WriteLine("Voulez - vous rejouez?? oui - non");
                reload = Console.ReadLine();
            }
        }
    }
}
