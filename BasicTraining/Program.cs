using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicTraining
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1;

            Console.Write("Sayı gir : ");
            sayi1 = Convert.ToInt32(Console.ReadLine());

            if (sayi1 < 0)
            {
                Console.WriteLine("Negatif");
            }
            else if (sayi1 == 0)
            {
                Console.WriteLine("Nötr");
            }
            else
            {
                Console.WriteLine("Pozitif");
            }
            Console.ReadKey();
        }
    }
}
