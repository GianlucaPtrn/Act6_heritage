using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Act6_Heritage_Ex1
{
    class Eleve : Personne
    {
        private String _classe;
        private String _adressKot;
        public String Classe
        {
            get { return _classe; }
            set { _classe = value; }
        }

        public String AddressKot
        {
            get { return _adressKot; }
            set { _adressKot = value; }
        }

        public Eleve(String nom, String adresse, int codePostale, String localite, string classe, string adressKot) : base(nom, adresse, codePostale, localite)
        {
            _nom = nom;
            _adresse = adresse;
            _codePostale = codePostale;
            _localite = localite;
            _classe = classe;
            _adressKot = adressKot;
        }
        public string FabriqueEtiq(String nom, String adresse, int codePostale, string addressKot)
        {
            string phrase = nom + " habite à " + addressKot + ", " + adresse + ", " + codePostale;
            return phrase;
        }
    }
}
