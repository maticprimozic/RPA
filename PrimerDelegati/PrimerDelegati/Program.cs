using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimerDelegati
{
    class Program
    {
        //1. definiraj si tip delegata
        //public delegate bool FunkcijaZaNize(string s);
        //2. napiši metodo, ki sprejme tega delegata kot parameter
        public static List<string> DelajOperacijeNadNizi(string[] m, Func<string,bool> mojaFunkcija) //namesto definicije zgoraj, kar tako func ki sprejema string in vrača bool
        {
            List<string> rezultat = new List<string>();
            foreach (var s in m)
            {
                if (mojaFunkcija(s))
                {
                    rezultat.Add(s);
                }
            }
            return rezultat;
        }
        //3. napiši metode, ki so tipa FunkcijaZaNize (ima en parameter tipa string, tip vrnjene vrednosti je bool)
        //public static bool ZačneZA(string s)
        //{
        //    return s.StartsWith("A");
        //}
        public static bool KončaZN(string s)
        {
            return s.EndsWith("n");
        }
        static void Main(string[] args)
        {
            string[] mojiNizi = { "Adam", "Alan", "Bob", "Steve", "Jim", "Aiden" };
            //FunkcijaZaNize an = delegate (string s) { return s.StartsWith("A"); }; //namesto metode ki smo jo definirali zgoraj
            //uporaba anonimnih metod
            //List<string> aji = DelajOperacijeNadNizi(mojiNizi, delegate (string s) { return s.StartsWith("A"); }); //tukaj kar zapišemo zgornjo metodo

            //anonimna metoda z lambda izrazi
            List<string> aji = DelajOperacijeNadNizi(mojiNizi, s => s.StartsWith("A"));  //lambda izraz za mojiNizi

            //List<string> nji = DelajOperacijeNadNizi(mojiNizi, KončaZN);
            //List<string> nji = DelajOperacijeNadNizi(mojiNizi, delegate (string s) { return s.EndsWith("n"); });
            List<string> nji = DelajOperacijeNadNizi(mojiNizi, s => s.EndsWith("n"));
            foreach (var x in aji)
            {
                Console.WriteLine(x);
            }
            Console.ReadLine();
        }
    }
}
