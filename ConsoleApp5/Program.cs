using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int a, b;
            //Console.WriteLine("Vize notunuzu giriniz");
            //a = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Final notunuzu giriniz");
            //b = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Ortalama:{0}", (a * 0.4) + (b * 0.6));

            //if ((a * 0.4) + (b * 0.6) < 60)
            //{
            //    Console.WriteLine("snıfta kaldınız");
            //}
            //else
            //{
            //    Console.WriteLine("sınıfı geçtiniz");
            //}
            //Console.ReadKey();

            //int toplam = 0;
            //int ort=0;
            //for (int i = 0; i <= 5; i++)

            //{
            //    toplam = toplam + i;
            //}
            //  Console.WriteLine("toplam={0}",toplam);
            //Console.WriteLine("ortalama değer={0}", toplam / 5);

            //string ad, soyad;
            //Console.Write("LÜTFEN ADINIZI GİRİNİZ:");
            // ad =Console.ReadLine();
            //Console.Write("lÜTFEN SOY ADINIZI GİRİNİZ:");
            // soyad=Console.ReadLine();
            //Console.WriteLine($"MERHABA {ad}{soyad},ARAMIZA HOŞGELDİNİZ!");
            //Console.ReadLine();
            while (true)
            {
                int a, b;
                int islem;
                Console.WriteLine("1.Dik üçgen ");
                Console.WriteLine("2.Kare");
                Console.WriteLine("3.Dikdörgen");
                Console.WriteLine("4.Beşgen");
                Console.WriteLine("5.altıgen");
                Console.Write("Lütfen Alanını hesaplamak istediğiniz çokgene ait numara giriniz:");
                islem = Convert.ToInt32(Console.ReadLine());
                if (islem == 1 || islem == 2 || islem ==3 || islem == 4 || islem==5)
                {

                    switch (islem)
                    {
                        case 1:
                            Console.Write("Lütfen üçgene ait yükseklik bilgisini giriniz:");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Lütfen üçgene ait taban bilgisini giriniz:");
                            b = Convert.ToInt32(Console.ReadLine());
                            int ucgensonuc = ucgen_function(a,b);
                            Console.WriteLine(ucgensonuc);

                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 2:
                            Console.Write("Lütfen kareye ait bir kenar bilgisini giriniz:");
                            a = Convert.ToInt32(Console.ReadLine());
                            int karesonuc = kare_function(a);
                            Console.WriteLine(karesonuc);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 3:
                            Console.Write("Lütfen dikdörtgene ait bir kenar bilgisini giriniz:");
                            a = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Lütfen dikdörtgene ait farklı bir kenar bilgisini giriniz:");
                            b = Convert.ToInt32(Console.ReadLine());

                            int dikdortgen = dikdortgen_function(a,b);
                            Console.WriteLine(dikdortgen);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 4:
                            Console.Write("Lütfen beşgene ait bir kenar bilgisini giriniz:");
                            a = Convert.ToInt32(Console.ReadLine());
                            double besgensonuc = besgen_function(a);
                            Console.WriteLine(besgensonuc);
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        case 5:
                            Console.WriteLine("Dört");
                            Console.ReadLine();
                            Console.Clear();
                            break;
                        default:
                            Console.WriteLine("Lütfen Geçerli bir sayı giriniz");
                            break;
                    }
                }
                else 
                {
                    Console.WriteLine("Lütfen Geçerli bir sayı Değeri giriniz! Örneğin (1,2,3,4,5)");
                    Console.ReadLine();
                    Console.Clear();
                }




            }

            
        }

        public static int ucgen_function(int a, int b)
        {
            return a * b / 2;
        }
        public static int dikdortgen_function(int a, int b)
        {
            return a * b ;
        }
        public static int kare_function(int a)
        {
            int sonuc = a * a;
            return sonuc;
        }
        public static double besgen_function(int a)
        {
            double bir_bolu_tan36 = 1.376381;
            double sabit = 5d / 4d;
            double sonuc = sabit*a*a* bir_bolu_tan36;
            return sonuc;
        }


    }
}
