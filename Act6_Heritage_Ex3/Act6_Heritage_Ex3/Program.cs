using System;

namespace Act6_Heritage_Ex3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine(" Bienvenue dans l'entreprise Petronio ");
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("");
            Console.WriteLine(" Voici tous les membres de l'entreprise ");
            Console.WriteLine("-----------------------------------------------------");

            Personne[] personnes = new Personne[10];
            for(int i = 0; i < 3; i++)
            {
                personnes[i] = new Employe(i, "Dorian", "Michaux", "21/01/2004");
            }
            for (int i = 3; i < 6; i++)
            {
                personnes[i] = new Ouvrier(i, "Gregory", "Martin", "27/04/2005", new DateTime(2020, 12, 02));
            }
            for (int i = 6; i < 9; i++)
            {
                personnes[i] = new Cadre(i, "Kim", "Gerard", "02/06/2006", 4);
            }
            for (int i = 9; i < 10; i++)
            {
                personnes[i] = new Directeur(i, "Gianluca", "Petronio", "19/10/2004", 13030, 38);
            }

            for (int x = 0; x < personnes.Length; x++)
            {
                Console.WriteLine(personnes[x].Caracteristique());
                Console.WriteLine(personnes[x].Salaire(personnes[x].CalcSalaire()));
            }
            Console.ReadLine();
        }
    }
}
