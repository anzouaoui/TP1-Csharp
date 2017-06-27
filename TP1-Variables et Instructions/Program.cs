using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP1_Variables_et_Instructions
{
    class Program
    {
        static void Main(string[] args)
        {
            #region EXERCICE 1
            decimal moyenne = 0;
            decimal nombre1, nombre2, nombre3;

            Console.WriteLine("Saisir un premier nombre");
            nombre1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Saisir un deuxième nombre");
            nombre2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Saisir un troisième nombre");
            nombre3 = Convert.ToInt32(Console.ReadLine());

            moyenne = (nombre1 + nombre2 + nombre3) / 3;
            Console.WriteLine("La moyenne est de {0}", moyenne);
            Console.ReadLine();
            #endregion

            #region EXERCICE 2

            #endregion  
        }
    }
}
