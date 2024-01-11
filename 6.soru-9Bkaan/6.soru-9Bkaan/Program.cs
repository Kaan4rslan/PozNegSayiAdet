using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.soru_9Bkaan
{
    class Program
    {
        static void Main(string[] args)
        {
            int pozsayi = 0;
            int negsayi = 0;

            Console.WriteLine("Bir sayı gir. sıfıra basınca program kapanır.");

  

            while (true)
            {
                Console.Write("sayi: ");
                int sayi = Convert.ToInt32(Console.ReadLine());

                if (sayi == 0)
                {
                    break;
                }
                if (sayi < 0)
                {
                    negsayi++;
                }
                else
                {
                    pozsayi++;
                }


            }

            Console.Clear();
            Console.WriteLine("negatif sayı adeti: " + negsayi);
            Console.WriteLine("pozitif sayı adeti: " + pozsayi);
            Console.Read();
        }
    }
}
