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
        // Girilen ismin uzunluğunu bulma ve 10 karakterden büyük mü sorusu
        static void Main(string[] args)
        {
            string ad;
            Console.Write("adınızı giriniz;");
            ad = Console.ReadLine();
            if (ad.Length > 10)
            {
                Console.WriteLine("uzun bir isme sahipsiniz");
            }
            else
            {
                Console.WriteLine("isminiz 10 karakterden az");
            }
           // Console.ReadKey(); 
            Console.WriteLine($"uzunluk degeri {ad.Length}");
        }
    }
}
