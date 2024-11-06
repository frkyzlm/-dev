using System;

public class Kisi
{
    
    public string Ad { get; private set; }
    public string Soyad { get; private set; }
    public string TelefonNumarasi { get; private set; }

    
    public Kisi(string ad, string soyad, string telefonNumarasi)
    {
        Ad = ad;
        Soyad = soyad;
        TelefonNumarasi = telefonNumarasi;
    }

    // Kisi Bilgisi Metodu: Kişinin tam adı ve telefon numarasını döndürür
    public string KisiBilgisi()
    {
        return $"{Ad} {Soyad} - Telefon: {TelefonNumarasi}";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Kullanıcıdan kişi bilgilerini al
        Console.Write("Adınızı girin: ");
        string ad = Console.ReadLine();

        Console.Write("Soyadınızı girin: ");
        string soyad = Console.ReadLine();

        Console.Write("Telefon numaranızı girin: ");
        string telefonNumarasi = Console.ReadLine();

        // Kisi nesnesini başlat
        Kisi kisi = new Kisi(ad, soyad, telefonNumarasi);

        // Kişi bilgilerini göster
        Console.WriteLine("\nKayıtlı Kişi Bilgisi:");
        Console.WriteLine(kisi.KisiBilgisi());

        
        Console.WriteLine("\nProgramı kapatmak için Enter tuşuna basın.");
        Console.ReadLine();  
    }
}
