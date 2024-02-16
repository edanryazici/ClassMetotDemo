using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            MusteriClass musteri = new MusteriClass();
            musteri.Id =1;
            musteri.Ad = "Edanur";
            musteri.Soyad = "Yazıcı";
            musteri.HesapNo = "123456789";

            MusteriClass musteri2 = new MusteriClass();
            musteri2.Id = 2;
            musteri2.Ad = "Bahar";
            musteri2.Soyad = "Felek";
            musteri2.HesapNo = "234567891";

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri);
            musteriManager.Listele(musteri);
            musteriManager.Listele(musteri2);
            musteriManager.Sil(musteri2.Id);

        }
    }
}
