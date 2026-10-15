using System;

namespace Seance02
{

    /*public class Duree
    {
        private int secondes;

        public Duree(int secondes)
        {
            if(secondes < 0)
            {
                throw new ArgumentOutOfRangeException( "Les secondes ne peuvent pas être négatives.");
            }
            this.secondes = secondes;
        }
        public Duree(): this(0){ }
        public Duree(int hours, int minutes, int seconds) : this (hours*3600+ minutes*60+ seconds) { }
        public Duree(Duree autre) : this(autre.secondes) { }
        public int TotalSecondes => secondes;
        public int Secondes => TotalSecondes % 60;

        public int Heures => TotalSecondes / 3600;
        public int Minutes => (TotalSecondes%3600) / 60;

        public void Ajouter(int secondes)
        {
            if (secondes < 0)
            {
                throw new ArgumentOutOfRangeException( "Les secondes ne peuvent pas être négatives."); ;
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
            int s = int.Parse(time[2]) ;
            return new Duree(h, m, s);
        }
    }*/


    public static class  OutilsTableau{

        public static void Echanger(ref int a, ref int b)
        {
            
            int c= a;
            a= b;
            b= c;
        }

        public static bool CalculerStats(int[] valeurs, out int min, out int max, out double
        moyenne)
        {
             max = 0;
             min = 0;
            moyenne = 0;
            if (valeurs == null || valeurs.Length == 0)
            {
                max = 0;
                min = 0;
                moyenne = 0;
                return false;
            }
            else
            {
                max = valeurs[0];
                min = valeurs[0];
                moyenne = 0;
                foreach (int v in valeurs)
                {
                    if (v > max)
                    {
                        max= v;

                    }
                    if (v < min)
                    {
                        min = v;

                    }
                    moyenne += v;
                }

                moyenne = moyenne / valeurs.Length;

                return true;
            }
        }

    }



    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
