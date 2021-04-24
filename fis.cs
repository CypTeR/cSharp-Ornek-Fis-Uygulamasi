using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            double fiyat = 0, toplam = 0, kdv = 10;
            Console.WriteLine("Ekmek için 1'e");
            Console.WriteLine("Peynir için 2'ye");
            Console.WriteLine("Çikolata için 3'e basınız");
            string secim = Console.ReadLine();
            if (secim=="1")
            {
                Console.WriteLine("Kaç adet ekmek: ");
                int adet = Convert.ToInt32(Console.ReadLine());
                fiyat = adet * 1.5;
                kdv = (fiyat * 1) / 100;
                toplam = fiyat + kdv;
         
            }
            else if (secim=="2")
            {
                Console.WriteLine("Kaç kg peynir: ");
                int adet = Convert.ToInt32(Console.ReadLine());
                fiyat = adet * 20;
                kdv = (fiyat * 8) / 100;
                toplam = fiyat + kdv;
            }
            else if (secim=="3")
            {
                Console.WriteLine("Kaç adet Çikolta: ");
                int adet = Convert.ToInt32(Console.ReadLine());
                fiyat = adet * 2;
                kdv = (fiyat * 18) / 100;
                toplam = fiyat + kdv;
            }
            else
                Console.WriteLine("Yanlış Seçim");

            Console.WriteLine("Toplam Fiyat: {0}",fiyat);
            Console.WriteLine("Toplam KDV: {0}",kdv);
            Console.WriteLine("Toplam :{0} ",toplam);

            Console.ReadLine();
        }
    }
}
