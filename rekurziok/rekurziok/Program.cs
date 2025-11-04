using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace rekurziok
{
    internal class Program
    {
        static bool Bennevan(List<int> lista, int i, int r)
        {
            if (lista.Count == i)
            {
                return false;
            }
            if (lista[i] == r)
            {
                return true;
            }
            return Bennevan(lista, i + 1, r);
        }
        static int Kereses(List<int> lista, int i, int r)
        {
            if (i == lista.Count)
            {
                return -1;
            }
            if (lista[i] == r)
            {
                return i;
            }
            return Kereses(lista, r, i + 1);
        }
        static int Osszegzes(List<int> lista, int i)
        {
            if (i == lista.Count)
            { 
                return 0; 
            }
            return lista[i] + Osszegzes(lista, i + 1);
        }
        static int Megszamolas_parosak(List<int> lista, int i)
        {
            if (i == lista.Count)
            {
                return 0;
            }
            int elemekszama = (lista[i] % 2 == 0) ? 1 : 0;
            return elemekszama + Megszamolas_parosak(lista, i + 1);
        }
        static List<int> Kivalogatas_parosak(List<int> lista, int i)
        {
            if (i == lista.Count)
            {
                return new List<int>();
            }
            List<int> elemekszama = Kivalogatas_parosak(lista, i + 1);
            if (lista[i] % 2 == 0)
            {
                elemekszama.Insert(0, lista[i]);
            }
            return elemekszama;
        }
        static int Maximumertek(List<int> lista, int i)
        {
            if (i == lista.Count - 1)
            {
                return lista[i];
            }
            int maxertek = Maximumertek(lista, i + 1);
            return (lista[i] > maxertek) ? lista[i] : maxertek;
        }
        static int Minimumertek(List<int> lista, int i)
        {
            if (i == lista.Count - 1)
            {
                return lista[i];
            }
            int minertek = Minimumertek(lista, i + 1);
            return (lista[i] < minertek) ? lista[i] : minertek;
        }
        static List<int> Ketszerezes(List<int> lista, int i)
        {
            if (i == lista.Count)
            {
                return new List<int>();
            }
            List<int> elemekszama = Ketszerezes(lista, i + 1);
            elemekszama.Insert(0, lista[i] * 2);
            return elemekszama;
        }
        static void Main(string[] args)
        {
        }
    }
}
