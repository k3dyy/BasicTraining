using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Math
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("5 ile 3 ün dört işlemi aşağıdaki gibidir; ");
            Dortislem dortIslem = new Dortislem();
            dortIslem.Topla(5, 3);
            dortIslem.Cikar(5, 3);
            dortIslem.Carpma(5, 3);
            dortIslem.Bolme(5, 3);

            Console.ReadKey();
        }
    }
}
