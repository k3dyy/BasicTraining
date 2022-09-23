using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    public class Dortislem
    {
        public void Topla(int sayi1, int sayi2)
        {
            int topla = sayi1 + sayi2;
            Console.WriteLine("Toplayınca Sonuç = " + topla);
        }
        public void Cikar(int sayi1, int sayi2)
        {
            int cikar = sayi1 - sayi2;
            Console.WriteLine("Çıkarınca Sonuç = " + cikar);
        }

        public void Carpma (int sayi1, int sayi2)
        {
            int carpma = sayi1 * sayi2;
            Console.WriteLine("Çarpınca sonuç = " + carpma);
        }
        public void Bolme (double sayi1 , double sayi2)
        {
            double bolme = sayi1 / sayi2;
            Console.WriteLine("Bölünce sonuç = " + bolme);
        }
    }
}
