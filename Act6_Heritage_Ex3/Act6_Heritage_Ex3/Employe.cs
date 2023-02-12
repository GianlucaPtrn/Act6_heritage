using System;
using System.Collections.Generic;
using System.Text;

namespace Act6_Heritage_Ex3
{
    class Employe : Personne
    {
        public Employe(int matricule, string nom, string prenom, string birthday) : base(matricule, nom, prenom, birthday)
        {
        }
        public string Caracteristique()
        {
            string sentence = "Prénom : " + Prenom + "\r\n" + "Nom : " + Nom + "\r\n" + "Matricule : " + Matricule + "\r\n" + "Date de naissance : " + Birthday;
            return sentence;
        }
    }
}
