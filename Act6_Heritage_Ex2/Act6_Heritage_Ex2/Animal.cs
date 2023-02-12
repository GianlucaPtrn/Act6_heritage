using System;
using System.Collections.Generic;
using System.Text;

namespace Act6_Heritage_Ex2
{
    class Animal
    {
		private string _nom;
		private DateTime _dateNaissance;
		private int _numeroPuce;
		private int _taille;
		private bool _concour;

        public string Nom
		{
			get { return _nom; }
			set { _nom = value; }
		}

        public DateTime DateNaissance
        {
            get { return _dateNaissance; }
            set { _dateNaissance = value; }
        }

        public int NumeroPuce
        {
            get { return _numeroPuce; }
            set { _numeroPuce = value; }
        }

        public int Taille
        {
            get { return _taille; }
            set { _taille = value; }
        }

        public bool Concour
        {
            get { return _concour; }
            set { _concour = value; }
        }

        public Animal(string nom, DateTime dateNaissance, int numeroPuce, int taille, bool concour)
        {
            Nom = nom;
            DateNaissance = dateNaissance;
            NumeroPuce = numeroPuce;
            Taille = taille;
            Concour = concour;
        }

        public string Dormir()
        {
            string sentence = " zzzz zzzz zzzz";
            return sentence;
        }

        public string Manger()
        {
            string sentence = " mmmmh c'est super bon !";
            return sentence;
        }
    }
}
