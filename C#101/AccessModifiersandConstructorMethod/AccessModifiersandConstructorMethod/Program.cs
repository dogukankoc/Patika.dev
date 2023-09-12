Console.WriteLine("Calisan1");
Calisan calisan = new Calisan("Ayşe","Kara",12365479,"IK");
calisan.CalisanBilgileri();
Console.WriteLine("Calisan2");
Calisan calisan2 = new Calisan("Ayşe", "Kara");
calisan2.CalisanBilgileri();

//Erişim Belirleyicileri
//Public
//Private
//Protected
//Internal


class Calisan
{
    public string Ad;
    public string Soyad;
    public int No;
    public string Departman;
    
    public Calisan(string ad, string soyad, int no, string departman)
    {
        this.Ad = ad;
        this.Soyad = soyad;
        this.No = no;
        this.Departman = departman;
    }
    public Calisan(string ad, string soyad)
    {
        this.Ad = ad;
        this.Soyad = soyad;
    }

    public Calisan() { }

    public void CalisanBilgileri()
    {
        Console.WriteLine("Çalışan Adı: {0}", this.Ad);
        Console.WriteLine("Çalışan Soyadı: {0}", this.Soyad);
        Console.WriteLine("Çalışan Numarası: {0}", this.No);
        Console.WriteLine("Çalışan Departmanı: {0}", this.Departman);
    }
}