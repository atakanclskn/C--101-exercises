using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.Versioning;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        //( Sayının tek mi? Çift mi? durumunu bulma )
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("Sayı giriniz:");
            sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi % 2 == 0)
            {
                Console.WriteLine("Sayı çifttir");
            }
            else
            {
                Console.WriteLine("Sayı tektir");
            }
            Console.ReadKey();

        }
    }
}
