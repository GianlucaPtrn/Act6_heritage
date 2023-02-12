using System;
using System.Collections.Generic;
using System.Text;

namespace Act6_Heritage_Ex1
{
    abstract class Personne
    {
        protected String _nom;
        protected String _adresse;
        protected int _codePostale;
        protected String _localite;

        public String Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }

        public String Adresse
        {
            get { return _adresse; }
            set { _adresse = value; }
        }

        public int CodePostale
        {
            get { return _codePostale; }
            set { _codePostale = value; }
        }

        public String Localité
        {
            get { return _localite; }
            set { _localite = value; }
        }

         public Personne(String nom, String adresse, int codePostale, String localite)
         {
            this._nom = nom;
            this._adresse = adresse;
            this._codePostale = codePostale;
            this._localite = localite;
        }

        public string FabriqueEtiq()
        {
            string phrase = _nom + " habite à " + _localite + ", " + _adresse + ", " + _codePostale;
            return phrase;
        }

        public string EstVoisin()
        {
            string phrase = "";
            return phrase;

        }
    }
}
