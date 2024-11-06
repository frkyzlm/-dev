using System;

public class KiralikArac
{
   
    public string Plaka { get; private set; }
    public decimal GunlukUcret { get; private set; }
    public bool MusaitMi { get; private set; }

    // Yapıcı Metot: Plaka ve günlük ücreti alır, MusaitMi varsayılan olarak true olur
    public KiralikArac(string plaka, decimal gunlukUcret)
    {
        Plaka = plaka;
        GunlukUcret = gunlukUcret;
        MusaitMi = true; // Varsayılan olarak araç müsait durumda
    }

    // Aracı kirala metodu: MusaitMi durumunu false yapar
    public void AraciKirala()
    {
        if (MusaitMi)
        {
            MusaitMi = false;
            Console.WriteLine($"{Plaka} plakalı araç kiralandı.");
        }
        else
        {
            Console.WriteLine($"{Plaka} plakalı araç zaten kirada.");
        }
    }

    // Aracı teslim et metodu: MusaitMi durumunu true yapar
    public void AraciTeslimEt()
    {
        if (!MusaitMi)
        {
            MusaitMi = true;
            Console.WriteLine($"{Plaka} plakalı araç teslim edildi.");
        }
        else
        {
            Console.WriteLine($"{Plaka} plakalı araç zaten müsait.");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Kullanıcıdan araç plaka ve günlük ücret bilgilerini al
        Console.Write("Araç plakasını girin: ");
        string plaka = Console.ReadLine();

        Console.Write("Günlük kiralama ücretini girin: ");
        decimal gunlukUcret = decimal.Parse(Console.ReadLine());

        // Kiralık araç başlat
        KiralikArac arac = new KiralikArac(plaka, gunlukUcret);

        while (true)
        {
            Console.WriteLine("\nBir işlem seçin:");
            Console.WriteLine("1 - Aracı Kirala");
            Console.WriteLine("2 - Aracı Teslim Et");
            Console.WriteLine("3 - Çıkış");
            Console.Write("Seçiminiz: ");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                arac.AraciKirala();
            }
            else if (secim == "2")
            {
                arac.AraciTeslimEt();
            }
            else if (secim == "3")
            {
                Console.WriteLine("Çıkış yapılıyor...");
                break;
            }
            else
            {
                Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
            }
        }

        
        Console.WriteLine("Programı kapatmak için Enter tuşuna basın.");
        Console.ReadLine();  
    }
}
