using System;

public class BankaHesabi
{
    // Özellikler
    public string HesapNumarasi { get; private set; }
    private decimal bakiye;

    // Bakiye özelliğine yalnızca sınıf içinden set erişimi
    public decimal Bakiye
    {
        get { return bakiye; }
        private set { bakiye = value; }
    }

    // Yapıcı Metot: Hesap numarasını ve ilk bakiyeyi alarak başlatır
    public BankaHesabi(string hesapNumarasi, decimal ilkBakiye)
    {
        HesapNumarasi = hesapNumarasi;
        Bakiye = ilkBakiye;
    }

    // Para Yatırma Metodu
    public void ParaYatir(decimal miktar)
    {
        if (miktar > 0)
        {
            Bakiye += miktar;
            Console.WriteLine($"{miktar} TL yatırıldı. Güncel bakiye: {Bakiye} TL");
        }
        else
        {
            Console.WriteLine("Yatırılacak miktar sıfırdan büyük olmalıdır.");
        }
    }

    // Para Çekme Metodu
    public void ParaCek(decimal miktar)
    {
        if (miktar > 0 && miktar <= Bakiye)
        {
            Bakiye -= miktar;
            Console.WriteLine($"{miktar} TL çekildi. Güncel bakiye: {Bakiye} TL");
        }
        else if (miktar > Bakiye)
        {
            Console.WriteLine("Yetersiz bakiye. İşlem gerçekleştirilemedi.");
        }
        else
        {
            Console.WriteLine("Çekilecek miktar sıfırdan büyük olmalıdır.");
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Kullanıcıdan hesap numarası ve ilk bakiye bilgilerini al
        Console.Write("Hesap numarasını girin: ");
        string hesapNumarasi = Console.ReadLine();

        Console.Write("İlk bakiyeyi girin: ");
        decimal ilkBakiye = decimal.Parse(Console.ReadLine());

        // Banka hesabını başlat
        BankaHesabi hesap = new BankaHesabi(hesapNumarasi, ilkBakiye);

        while (true)
        {
            Console.WriteLine("\nBir işlem seçin:");
            Console.WriteLine("1 - Para Yatır");
            Console.WriteLine("2 - Para Çek");
            Console.WriteLine("3 - Çıkış");
            Console.Write("Seçiminiz: ");
            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.Write("Yatırmak istediğiniz miktarı girin: ");
                decimal miktar = decimal.Parse(Console.ReadLine());
                hesap.ParaYatir(miktar);
            }
            else if (secim == "2")
            {
                Console.Write("Çekmek istediğiniz miktarı girin: ");
                decimal miktar = decimal.Parse(Console.ReadLine());
                hesap.ParaCek(miktar);
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

        // Programın kapanmasını önlemek için bekleme
        Console.WriteLine("Programı kapatmak için Enter tuşuna basın.");
        Console.ReadLine();  // Kapanmayı önlemek için bekler
    }
}
