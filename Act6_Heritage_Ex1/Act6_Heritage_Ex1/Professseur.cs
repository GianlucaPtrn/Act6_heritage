using System;
using System.Collections.Generic;
using System.Text;

namespace Act6_Heritage_Ex1
{
    class Professeur : Personne
    {
        private String _specialisation;

        public String Specialisation
        {
            get { return _specialisation; }
            set { _specialisation = value; }
        }

        public Professeur(String nom, String adresse, int codePostale, String localite, string specialisation) : base(nom, adresse, codePostale, localite)
        {
            _nom = nom;
            _adresse = adresse;
            _codePostale = codePostale;
            _localite = localite;
            _specialisation = specialisation;
        }
    }
}
