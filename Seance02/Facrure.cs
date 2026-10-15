using System;
using System.Collections.Generic;
using System.Text;

namespace Seance02
{



    
        public class Facture
        {
            private const string Prefixe = "FAC-2026";
            private static int compteur = 0;

            public string Numero { get; }

            public Facture()
            {

                compteur++;
                Numero = $"{Prefixe}-{compteur:D4}";
            }

            internal static void ReinitialiserCompteur()
            {
                compteur = 0;
            }
        }
    }

