using System;
using System.Collections.Generic;
using System.Text;

namespace Act6_Heritage_Ex2
{
    class Chat : Animal
    {
        public Chat(string nom, DateTime dateNaissance, int numeroPuce, int taille, bool concour) : base(nom, dateNaissance, numeroPuce, taille, concour)
        {
            Nom = nom;
            DateNaissance = dateNaissance;
            NumeroPuce = numeroPuce;
            Taille = taille;
            Concour = concour;
        }

        public string Miauler()
        {
            string sentence = " Miaou Miaou Miaou ";
            return sentence;
        }

        public string Sentence()
        {
            string sentence = Nom + " le Chat, née le " + DateNaissance + " ça taille est de " + Taille + " et son numero de puce est " + NumeroPuce + "et participe t'il au concour ? " + Concour;
            return sentence;
        }
    }
}
