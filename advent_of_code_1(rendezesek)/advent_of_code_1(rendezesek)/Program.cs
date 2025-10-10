using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace advent_of_code_1_rendezesek_
{
    internal class Program
    {
        
        static int TeljesTavolsag(List<int> ballista, List<int> jobblista)
        {
            int tavolsag = 0;
            for (int i = 0; i < ballista.Count; i++)
            {
                int kulonbseg = Math.Abs(ballista[i] - jobblista[i]);
                Console.WriteLine($"{i + 1}. pár: {ballista[i]} és {jobblista[i]} ->" +
                    $" " + $"távolság: {kulonbseg}");
                tavolsag += kulonbseg;
            }
            Console.WriteLine($"\nteljes távolság: {tavolsag}");
            return tavolsag;
        }
        static void Main(string[] args)
        {
            List<int> ballista = new List<int> { 3, 4, 2, 1, 3, 3 };
            List<int> jobblista = new List<int> { 4, 3, 5, 3, 9, 3 };
            TeljesTavolsag(ballista, jobblista);
        }
    }
}
