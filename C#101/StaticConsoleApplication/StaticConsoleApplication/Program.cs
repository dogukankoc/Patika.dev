Console.WriteLine($"Calisan Sayisi:{Calisan.CalisanSayisi}");

Calisan calisan = new Calisan("Ayşe","Kara","İnsan Kaynakları");
Console.WriteLine($"Calisan Sayisi:{Calisan.CalisanSayisi}");

Calisan calisan1 = new Calisan("Doğukan", "Koç", "Yazılım Geliştirme");
Calisan calisan2 = new Calisan("Murat", "Kara", "Muhasebe");
Console.WriteLine($"Calisan Sayisi:{Calisan.CalisanSayisi}");

Console.WriteLine($"Toplam:{Islemler.Topla(100,200)}");
Console.WriteLine($"Fark:{Islemler.Cikar(400,50)}");
class Calisan
{
    private static int calisanSayisi;
    public static int CalisanSayisi {get => calisanSayisi;}

    private string Isim;
    private string Soyİsim;
    private string Departman;

    static Calisan()
    {
        //Static Constructorların geri dönüş tipi ve erişim belirteçleri olmaz.
        calisanSayisi = 0;

    }
    public Calisan (string isim, string soyİsim, string departman)
    {
        this.Isim = isim;
        this.Soyİsim = soyİsim;
        this.Departman = departman;
        calisanSayisi++;
    }
}

//Static Class içerisinde static olmayan eleman kullanılamaz

static class Islemler
{
    public static long Topla(int sayi1, int sayi2)
    {
        return sayi1 + sayi2;
    }

    public static long Cikar(int sayi1, int sayi2)
    {
        return sayi1 - sayi2;
    }
}