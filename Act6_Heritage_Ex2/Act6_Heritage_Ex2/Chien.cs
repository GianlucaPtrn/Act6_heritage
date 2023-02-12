using System;
using System.Collections.Generic;
using System.Text;

namespace Act6_Heritage_Ex2
{
    class Chien : Animal
    {
        public Chien(string nom, DateTime dateNaissance, int numeroPuce, int taille, bool concour):base(nom, dateNaissance,numeroPuce,taille, concour)
        {
            Nom = nom;
            DateNaissance = dateNaissance;
            NumeroPuce = numeroPuce;
            Taille = taille;
            Concour = concour;
        }

        public string Aboyer()
        {
            string sentence = " ouaf ouaf ouaf ";
            return sentence;
        }

        public string Sentence()
        {
            string sentence = Nom + " le chien, née le " + DateNaissance + " ça taille est de " + Taille + " et son numero de puce est " + NumeroPuce + "et participe t'il au concour ? " + Concour;
            return sentence;
        }
    }
}
