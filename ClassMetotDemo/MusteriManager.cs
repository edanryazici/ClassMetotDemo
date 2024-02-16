using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(MusteriClass musteri)
        {
            Console.WriteLine("Musteri Eklendi! : " + musteri.Ad);
        }

        public void Sil(int id)
        {
            Console.WriteLine("Müşteri Silindi! Silinen müşteri no: " + id);
        }

        public void Listele(MusteriClass musteri)
        {
            Console.WriteLine("------ Müşteri Bilgileri -------");
            Console.WriteLine(musteri.Id);
            Console.WriteLine(musteri.Ad);
            Console.WriteLine(musteri.Soyad);
            Console.WriteLine(musteri.HesapNo);
            Console.WriteLine("--------------");
        }
    }
}
