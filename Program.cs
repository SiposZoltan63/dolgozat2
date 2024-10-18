using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sz2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> pozitivSzamok = new List<int>();
            List<int> negativSzamok = new List<int>();

            int pozitivSzamokOsszege = 0;
            int negativSzamokOsszege = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Kérlek, adj meg egy {i + 1} egész számot: ");
                int szamok = Convert.ToInt32(Console.ReadLine());

                if (szamok >= 0)
                {
                    pozitivSzamok.Add(szamok);
                    pozitivSzamokOsszege += szamok;
                }
                else
                {
                    negativSzamok.Add(szamok);
                    negativSzamokOsszege += szamok;
                }
            }
            Console.WriteLine(pozitivSzamok);
            Console.WriteLine("Pozitív számok összege: " + pozitivSzamokOsszege);

            Console.WriteLine(negativSzamok);
            Console.WriteLine("Negatív számok összege: " + negativSzamokOsszege);

            Console.ReadKey();
        }
    }
}
