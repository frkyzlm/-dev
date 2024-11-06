using System;
using System.Collections.Generic;

public class Kitap
{
    // Özellikler
    public string Ad { get; private set; }
    public string Yazar { get; private set; }

    // Yapıcı Metot: Kitap adı ve yazar bilgilerini alarak başlatır
    public Kitap(string ad, string yazar)
    {
        Ad = ad;
        Yazar = yazar;
    }

    // Kitap Bilgisi Metodu
    public string KitapBilgisi()
    {
        return $"{Ad} - Yazar: {Yazar}";
    }
}

public class Kutuphane
{
    // Özellik
    public List<Kitap> Kitaplar { get; private set; }

    // Yapıcı Metot: Kitaplar listesi boş olarak başlatılır
    public Kutuphane()
    {
        Kitaplar = new List<Kitap>();
    }

    // Kitap Ekle Metodu: Kitabı kütüphaneye ekler
    public void KitapEkle(Kitap yeniKitap)
    {
        this.Kitaplar.Add(yeniKitap); // this ile kütüphaneye ait olduğunu belirtiyoruz
        Console.WriteLine($"{yeniKitap.KitapBilgisi()} kütüphaneye eklendi.");
    }

    // Kitapları Listele Metodu: Tüm kitapları listeler
    public void KitaplariListele()
    {
        Console.WriteLine("\nKütüphanedeki Kitaplar:");
        foreach (var kitap in Kitaplar)
        {
            Console.WriteLine(kitap.KitapBilgisi());
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        
        Kutuphane kutuphane = new Kutuphane();

       
        while (true)
        {
            Console.Write("Kitap adı girin (Çıkmak için boş bırakın): ");
            string kitapAdi = Console.ReadLine();

            if (string.IsNullOrEmpty(kitapAdi))
            {
                break;
            }

            Console.Write("Yazar adı girin: ");
            string yazarAdi = Console.ReadLine();

            // Yeni Kitap nesnesi oluştur ve kütüphaneye ekle
            Kitap yeniKitap = new Kitap(kitapAdi, yazarAdi);
            kutuphane.KitapEkle(yeniKitap);
        }

        // Kütüphanedeki kitapları listele
        kutuphane.KitaplariListele();

        
        Console.WriteLine("\nProgramı kapatmak için Enter tuşuna basın.");
        Console.ReadLine();
    }
}
