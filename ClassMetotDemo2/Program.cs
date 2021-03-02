using System;

namespace ClassMetotDemo
{




    class Program
    {
        static void Main(string[] args)
        {

            MusteriManager musteri = new MusteriManager();

            Console.WriteLine("1-Musteri Ekle/n  2-Musteri Listele/n  3-Musteri Sil/n  4-Cıkıs");

            int sayi;

            Musteri m = new Musteri();

            do
            {
                Console.WriteLine("Secim Yapiniz..");

                sayi = Convert.ToInt32(Console.ReadLine());

                switch (sayi)
                {
                    case 1:
                        musteri.mEkle(m);
                        break;

                    case 2:
                        musteri.mListele(m);
                        break;

                    case 3:
                        musteri.mSil(ref m);
                        break;

                    default:
                        break;
                }
            } while (sayi != 4);



        }
    }
}
