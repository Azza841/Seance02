using System;
using System.Collections.Generic;
using System.Text;

namespace Seance02
{
    public class Duree
    {
        private int secondes;

        public Duree(int secondes)
        {
            if (secondes < 0)
            {
                throw new ArgumentOutOfRangeException("Les secondes ne peuvent pas être négatives.");
            }
            this.secondes = secondes;
        }
        public Duree() : this(0) { }
        public Duree(int hours, int minutes, int seconds) : this(hours * 3600 + minutes * 60 + seconds) { }
        public Duree(Duree autre) : this(autre.secondes) { }
        public int TotalSecondes => secondes;
        public int Secondes => TotalSecondes % 60;

        public int Heures => TotalSecondes / 3600;
        public int Minutes => (TotalSecondes % 3600) / 60;

        public void Ajouter(int secondes)
        {
            if (secondes < 0)
            {
                throw new ArgumentOutOfRangeException("Les secondes ne peuvent pas être négatives."); ;
            }
            this.secondes += secondes;
        }

        public void Ajouter(Duree autre)
        {
            Ajouter(autre.secondes);
        }
        public override string ToString()
        {
            return $"{Heures:D2}:{Minutes:D2}:{Secondes:D2}";
        }

        public static Duree Parse(string texte)
        {

            string[] time = texte.Split(':');

            int h = int.Parse(time[0]);
            int m = int.Parse(time[1]);
            int s = int.Parse(time[2]);
            return new Duree(h, m, s);
        }
    }
}
