using System;
using System.Collections.Generic;
using System.Text;

namespace Act6_Heritage_Ex3
{
    class Directeur : Personne
    {
        private double _chiffreAffaire;
        private double _pourcentage;

        public double ChiffreAffaire
        {
            get { return _chiffreAffaire; }
            set { _chiffreAffaire = value; }
        }

        public double Pourcentage
        {
            get { return _pourcentage; }
            set { _pourcentage = value; }
        }

        public Directeur(int matricule, string nom, string prenom, string birthday, double chiffreAffaire, double pourcentage) : base(matricule, nom, prenom, birthday)
        {
            _chiffreAffaire = chiffreAffaire;
            _pourcentage = pourcentage;
        }

        public double CalcSalaire()
        {
            double salaire = (ChiffreAffaire * Pourcentage) / 100;
            return salaire;
        }
    }
}
