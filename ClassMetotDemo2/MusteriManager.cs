using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public Musteri mEkle(Musteri m)
        {

            Console.WriteLine("Musterinin Adi: ");
            m.mAd = Console.ReadLine();
            Console.WriteLine("Musterinin Soyadi: ");
            m.mSoyad = Console.ReadLine();
            Console.WriteLine("Musterinin Adresi: ");
            m.mAdres = Console.ReadLine();
            return m;

        }

        public void mListele(Musteri musteri)
        {
            Console.WriteLine(musteri.mAd);
            Console.WriteLine(musteri.mSoyad);
            Console.WriteLine(musteri.mAdres);
        }

        public void mSil(ref Musteri m)
        {
            m.mAd = "";
            m.mSoyad = "";
            m.mAdres = "";
        }

    }

}
