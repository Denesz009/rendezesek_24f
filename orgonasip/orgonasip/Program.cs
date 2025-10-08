using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orgonasip
{
    internal class Program
    {
        static Random r = new Random(); // general random szamokat

        static void Orgonasipok(List<int> lista)
        {
            lista.Sort(); 
            lista.Reverse(); 

            List<int> lista2 = new List<int>();
            lista2.Add(lista[0]); //leteszi a legnagyobb szamot

            bool jobbra = true; // valtakozva tesszük be az elemeket
            for (int i = 1; i < lista.Count; i++)
            {
                if (jobbra) 
                {
                    lista2.Add(lista[i]); //lista vegere
                }
                else 
                {
                    lista2.Insert(0, lista[i]); // lista elejere
                }
                jobbra = !jobbra; // iranvaltas
            }

            for (int i = 0; i < lista.Count; i++)
            {
                lista[i] = lista2[i];
            }
        }

        static List<int> Generator(int hossz, int legkisebb, int legnagyobb)
        {
            List<int> lista = new List<int>();
            for (int i = 0; i < hossz; i++)
            {
                lista.Add(r.Next(legkisebb, legnagyobb + 1)); // mindig uj szám, mivel az r maradt
            }
            return lista;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Teszt:\n");

            for (int i = 1; i <= 3; i++) // teszteles
            {
                List<int> szamok = Generator(10, 1, 67);

                Console.WriteLine($"Alap {i}:");
                Console.WriteLine(string.Join(", ", szamok));

                Orgonasipok(szamok);

                Console.WriteLine("Rendezett:");
                Console.WriteLine(string.Join(", ", szamok));
                Console.WriteLine(new string('-', 50));
            }
        }
    }
}
