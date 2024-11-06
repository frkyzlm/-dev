using System;

public class Urun
{
    // Özellikler
    public string Ad { get; private set; }
    public decimal Fiyat { get; private set; }
    private decimal indirim;

    
    public decimal Indirim
    {
        get { return indirim; }
        set
        {
            if (value >= 0 && value <= 50)
            {
                indirim = value;
            }
            else
            {
                Console.WriteLine("İndirim değeri 0 ile 50 arasında olmalıdır.");
            }
        }
    }

   
    public Urun(string ad, decimal fiyat)
    {
        Ad = ad;
        Fiyat = fiyat;
    }

    
    public decimal IndirimliFiyat()
    {
        return Fiyat * (1 - Indirim / 100);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Kullanıcıdan ürün adı ve fiyat bilgilerini al
        Console.Write("Ürün adını girin: ");
        string ad = Console.ReadLine();

        Console.Write("Ürün fiyatını girin: ");
        decimal fiyat = decimal.Parse(Console.ReadLine());

        // Ürünü başlat
        Urun urun = new Urun(ad, fiyat);

        // Kullanıcıdan indirim oranını al
        Console.Write("İndirim oranını girin (0-50%): ");
        decimal indirimOrani = decimal.Parse(Console.ReadLine());
        urun.Indirim = indirimOrani;

        // İndirimli fiyatı göster
        Console.WriteLine($"İndirimli Fiyat: {urun.IndirimliFiyat()} TL");

        // Programın kapanmasını önlemek için bekleme
        Console.WriteLine("Programı kapatmak için Enter tuşuna basın.");
        Console.ReadLine();  // Kapanmayı önlemek için bekler
    }
}
