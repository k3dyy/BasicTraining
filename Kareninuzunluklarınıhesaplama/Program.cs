using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kareninuzunluklarınıhesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            Console.Write("Karenin kenar uzunluğunu giriniz = ");
            int kenaruzunlugu = Convert.ToInt32(Console.ReadLine());

            int alanuzunlugu = kenaruzunlugu * 4;
            Console.WriteLine("Alan uzunluğu = " + alanuzunlugu );

            int cevreuzunlugu = kenaruzunlugu * kenaruzunlugu;
            Console.WriteLine("Çevre uzunluğu = " + cevreuzunlugu);

            Console.ReadKey();
        }
    }
}
