using System;

namespace Act6_Heritage_Ex2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2018,10,1);
            DateTime date2 = new DateTime(2019,2,4);
            DateTime date3 = new DateTime(2020,1,10);

            Chat chat1 = new Chat("Tom", date1, 377263, 50, true);
            Chien Chien1 = new Chien("Jerry", date2, 373453, 50, true);
            Lapin lapin1 = new Lapin("Marque", date3, 567263, 50, false);

            Console.WriteLine("-----------------------------------------------------------");
            Console.WriteLine(" bienvenu dans la classe ANIMAL ");
            Console.WriteLine("-----------------------------------------------------------");

            string reload = "yes";
            while(reload == "yes")
            {
                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("Le chat s'est endormi : " + chat1.Dormir());
                Console.WriteLine("Le chat s'est endormi : " + Chien1.Dormir());
                Console.WriteLine("Le chat s'est endormi : " + lapin1.Dormir());
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("");

                Console.WriteLine("");
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine(chat1.Sentence());
                Console.WriteLine(Chien1.Sentence());
                Console.WriteLine(lapin1.Sentence());
                Console.WriteLine("-----------------------------------------------------------");
                Console.WriteLine("");

                Console.WriteLine("Voulez vous rejouez ?  oui - non ");
                Console.ReadLine();
            }
        }
    }
}
