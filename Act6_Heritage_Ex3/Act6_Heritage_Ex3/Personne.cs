using System;
using System.Collections.Generic;
using System.Text;

namespace Act6_Heritage_Ex3
{
    class Personne
    {
        protected int _matricule;
        protected string _nom;
        protected string _prenom;
        protected string _birthday;

        public int Matricule
        {
            get { return _matricule; }
            set { _matricule = value; }
        }
        public string Nom
        {
            get { return _nom; }
            set { _nom = value; }
        }
        public string Prenom
        {
            get { return _prenom; }
            set { _prenom = value; }
        }
        public string Birthday
        {
            get { return _birthday; }
            set { _birthday = value; }
        }
        public Personne(int matricule, string nom, string prenom, string birthday)
        {
            _matricule = matricule;
            _nom = nom;
            _prenom = prenom;
            _birthday = birthday;
        }

        public string Salaire(double salaire)
        {
            string sentence = "Le salaire mensuel de l'ouvrier est de " + salaire + " écus";
            return sentence;
        }
        public double CalcSalaire()
        {
            double salaire = 0;
            return salaire;
        }
        public string Caracteristique()
        {
            string sentence = "\n" + "Prénom : " + Prenom + "\r\n" + "Nom : " + Nom + "\r\n" + "Matricule : " + Matricule + "\r\n" + "Date de naissance : " + Birthday;
            return sentence;
        }
    }
}
