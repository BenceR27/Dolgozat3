using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dolgozat3
{
    internal class Program
    {
        static void pontszam()
        {
            string[] Nevek = new string[5];
            int[] pontszamok = new int[5];

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Kérlek, add meg a {i + 1}. diák nevét:");
                Nevek[i] = Console.ReadLine();

                Console.WriteLine($"Kérlek, add meg a(z) {Nevek[i]} pontszámát:");
                pontszamok[i] = int.Parse(Console.ReadLine());
            }

            double atlag = 0;
            int legmagasabbPontszam = pontszamok[0];
            string legmagasabbDiak = Nevek[0];
            int legalacsonyabbPontszam = pontszamok[0];
            string legalacsonyabbDiak = Nevek[0];

            for (int i = 0; i < 5; i++)
            {
                atlag += pontszamok[i];

                if (pontszamok[i] > legmagasabbPontszam)
                {
                    legmagasabbPontszam = pontszamok[i];
                    legmagasabbDiak = Nevek[i];
                }

                if (pontszamok[i] < legalacsonyabbPontszam)
                {
                    legalacsonyabbPontszam = pontszamok[i];
                    legalacsonyabbDiak = Nevek[i];
                }
            }

            atlag /= 5;

            Console.WriteLine($"Az átlagpontszám: {atlag}");
            Console.WriteLine($"A legmagasabb pontszám: {legmagasabbPontszam} ({legmagasabbDiak})");
            Console.WriteLine($"A legalacsonyabb pontszám: {legalacsonyabbPontszam} ({legalacsonyabbDiak})");

            bool vanElegtelen = false;
            for (int i = 0; i < 5; i++)
            {
                if (pontszamok[i] < 50)
                {
                    vanElegtelen = true;
                    break;
                }
            }

            if (vanElegtelen)
            {
                Console.WriteLine("Van elégtelen pontszám!");
            }
        }
        static void Main(string[] args)
        {
            pontszam();
        }
    }
}
