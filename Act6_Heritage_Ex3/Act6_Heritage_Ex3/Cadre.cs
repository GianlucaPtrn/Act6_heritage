using System;
using System.Collections.Generic;
using System.Text;

namespace Act6_Heritage_Ex3
{
    class Cadre : Personne
    {
        private int _indice;

        public int Indice
        {
            get { return _indice; }
            set { _indice = value; }
        }

        public Cadre(int matricule, string nom, string prenom, string birthday, int indice) : base(matricule, nom, prenom, birthday)
        {
            _indice = indice;
        }

        public double CalcSalaire()
        {
            double salaire = 0;
            switch (Indice)
            {
                case 1:
                    salaire = 13000;
                    break;
                case 2:
                    salaire = 15000;
                    break;
                case 3:
                    salaire = 17000;
                    break;
                case 4:
                    salaire = 20000;
                    break;
            }

            return salaire;
        }
    }
}
