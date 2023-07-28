using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kampİntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip 
            string kategoriEtiketi = "Kategori";

            int sayi = 9;

            double faizOrani = 2.8;

            bool sistemGiris = false; // iki durum vardır; sisteme giriş yapıldı- giriş yapılmadı yani true ve false

            double dDun = 7.35;

            double dBugun = 7.45;

            if (dDun>dBugun)
            {
                Console.WriteLine("Azalış butonu");
            }
            else if (dDun<dBugun)
            {
                Console.WriteLine( "Artış butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }


            if (sistemGiris == true)
            {
                Console.WriteLine("kullanıcı ayarları butonu");
            }
            else
            {
                Console.WriteLine("Giriş yap butonu");
            }

            Console.WriteLine(sayi);
        }
    }
}
