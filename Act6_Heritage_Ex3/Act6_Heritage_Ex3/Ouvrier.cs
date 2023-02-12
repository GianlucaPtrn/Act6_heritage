﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Act6_Heritage_Ex3
{
    class Ouvrier : Personne
    {
        private DateTime _dateEntree;

        public DateTime DateEntree
        {
            get { return _dateEntree; }
            set { _dateEntree = value; }
        }

        public Ouvrier(int matricule, string nom, string prenom, string birthday, DateTime dateEntree) : base(matricule, nom, prenom, birthday)
        {
            _dateEntree = dateEntree;
        }

        public double CalcDate()
        {
            DateTime date = DateTime.Now;
            TimeSpan diff = date.Subtract(DateEntree);
            double years = diff.TotalDays / 365.0;
            return years;
        }

        public double CalcSalaire()
        {
            double annee = CalcDate();
            double salaire = 2500;

            for (int i = 0; i < annee - 1; i++)
            {
                if (salaire < 5000)
                {
                    salaire = salaire + 100;
                }
            }

            return salaire;
        }
    }
}
