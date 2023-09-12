Ogrenci ogrenci = new Ogrenci();
ogrenci.Isim = "Ayşe";
ogrenci.Soyisim = "Yılmaz";
ogrenci.OgrenciNo = 123;
ogrenci.Sinif = 3;
ogrenci.OgrenciBilgileriniGetir();

ogrenci.SinifAtlat();
Console.WriteLine("Sınıf Atlattıktan Sonra");
ogrenci.OgrenciBilgileriniGetir();

Ogrenci ogrenci2 = new Ogrenci("Deniz", "Arda", 256, 1);
ogrenci2.SinifDusur();
ogrenci2.SinifDusur();
ogrenci2.OgrenciBilgileriniGetir();

class Ogrenci
{
    private string isim;
    private string soyisim;
    private int ogrenciNo;
    private int sinif;

    public string Isim
    {
        get { return isim; }
        set { isim = value; }
    }

    public string Soyisim { get => soyisim; set => soyisim = value; }
    public int OgrenciNo { get => ogrenciNo; set => ogrenciNo = value; }
    public int Sinif
    {
        get => sinif;

        set
        {
            if (value < 1)
            {
                Console.WriteLine("Sınıf en az 1 olabilir");
                sinif = 1;
            }
            else
            {
               sinif = value;
            }
        }
    }

    public Ogrenci() { }

    public Ogrenci(string isim, string soyisim, int ogrenciNo, int sinif)
    {
        Isim = isim;
        Soyisim = soyisim;
        OgrenciNo = ogrenciNo;
        Sinif = sinif;
    }
    public void OgrenciBilgileriniGetir()
    {
        Console.WriteLine("Öğrenci Bilgileri");
        Console.WriteLine($"Öğrenci Adı : {this.isim}");
        Console.WriteLine($"Öğrenci Soyadı : {this.soyisim}");
        Console.WriteLine($"Öğrenci Numarası : {this.ogrenciNo}");
        Console.WriteLine($"Öğrenci Sınıfı : {this.sinif}");
    }
    public void SinifAtlat()
    {
        this.sinif = this.sinif+1;
    }
    public void SinifDusur()
    {
        this.sinif = this.sinif-1;
    }
}