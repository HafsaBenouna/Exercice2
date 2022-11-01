using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Nbr;
            int[] tableau = new int[10];
            tableau[0] = 5;
            tableau[1] = 9;
            tableau[2] = 10;
            tableau[3] = 16;
            tableau[4] = 19;
            tableau[5] = 20;
            tableau[6] = 22;
            tableau[7] = 25;
            tableau[8] = 27;
            

            affiche_tab(tableau);
            Console.WriteLine("entrez un nombre ");
            Nbr = int.Parse(Console.ReadLine());
            Inserer_val(tableau, Nbr);
            affiche_tab(tableau);
        }
        public static void affiche_tab(int[] tableau)
        {
            for (int i = 0; i < tableau.Length; i++)
            {
                Console.WriteLine(tableau[i]);

            }
        }

        public static void Inserer_val(int[] tableau, int Nbr)
        {
            int pos = 0;
            for (int i = 0; i < tableau.Length; i++)
            {
                if (tableau[i] >= Nbr)
                    pos = i;
                break;

            }
            for (int j = pos; j < tableau.Length; j++)
            {
                tableau[j + 1] = tableau[j];
            }
            tableau[pos] = Nbr;
        }




    }
}
