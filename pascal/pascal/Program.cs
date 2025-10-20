using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pascal
{
    internal class Program
    {
        static string[,] Pascal_teglalap()
        {
            return new string[,]
            {
            { "P", "A", "S", "C" },
            { "A", "S", "C", "A" },
            { "S", "C", "A", "L" }
            };
        }
        static void Teglalap_kiiras(string[,] teglalap)
        {
            int sorok = teglalap.GetLength(0);
            int oszlopok = teglalap.GetLength(1);

            for (int i = 0; i < sorok; i++)
            {
                for (int j = 0; j < oszlopok; j++)
                {
                    Console.Write(teglalap[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
        static int SzamolUtak(int sorok, int oszlopok)
        {
            int[,] utak = new int[sorok, oszlopok];
            for (int j = 0; j < oszlopok; j++)
            {
                utak[0, j] = 1;
            }
            for (int i = 0; i < sorok; i++)
            {
                utak[i, 0] = 1;
            }
            for (int i = 1; i < sorok; i++)
            {
                for (int j = 1; j < oszlopok; j++)
                {
                    utak[i, j] = utak[i - 1, j] + utak[i, j - 1];
                }
            }

            return utak[sorok - 1, oszlopok - 1];
        }
        static void Main(string[] args)
        {
            string[,] teglalap = Pascal_teglalap();
            Teglalap_kiiras(teglalap);
            int utakSzama = SzamolUtak(teglalap.GetLength(0),
            teglalap.GetLength(1));
            Console.WriteLine(utakSzama);
        }
    }
}
