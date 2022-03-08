// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Kalıtım OOP EN ÖNEMLİ ÖZELLİĞİDİR.
//Üretilen CLASS'TAN farklı bir nesneye özelliklerini aktarabilmekte ve böylece aynı olan özellikleri tekrar tekrar yazmamızın önüne geçilmekte..
//Bir programcı açısında bu özellik =>>
//Aynı aile grubundan gelen nesnelerin yada yatayda olan tüm olguların benzer özelliklerini tekrar tekrar herbirinden tanımlanmaktansa
//üst sınıfta tanımlanması ve her bir alt sınıfa miras yolu ile bu özelliklerin aktarılması olayıdır.
//Böylece hem kod maliyeti, hem de mimarisel açıdan tasarımsal açıdan avantaj sağlanmaktadır.

Muhasebeci msb = new Muhasebeci();
Yazilimci yzl = new Yazilimci();

List<string> tt = new List<string>();
tt.Add("C#");
tt.Add("LabView");
yzl.KullandigiDiller = tt;
Yonetici yon = new Yonetici();
yon.yuksekmaas = 550;
Console.WriteLine(yon.yuksekmaas.ToString());


Personel pr = new Personel();
pr.MedeniHal = false;
Console.WriteLine(pr.MedeniHal ? pr.Cinsiyet = "erkek" : pr.Cinsiyet = "kadın");
int a = 22;
Console.WriteLine(
    
    a<10 && a>5 ? "5 le 10 arasında" :
    a<20 && a>10 ? "10 la 20 arasında" :
    a<30 && a>20 ? "20 ile 30 arasında" :
    a==10 ? "10 a eşittir" :
    "40 dan büyük"
    );
   






class Personel
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public bool MedeniHal { get; set; }
    public string Cinsiyet { get; set; }
}


class Muhasebeci : Personel
{
    
}

class Yazilimci: Personel
{
    public List<string>  KullandigiDiller { get; set; }
}

class Yonetici : Personel
{
    private int YuksekMaas;

    public int yuksekmaas
    {
        get 
        { 
            return YuksekMaas+654654; 
        }
        set
        {
            if (value>500)
            {
                Console.WriteLine("value 500'den büyük");
            };
        }
    }




}

//Yukarıdaki her nesne için ayrı ayrı çalışan sınıflarınmı oluşturdum. Hepsi için ortak olan özellikler altında tekrar etti.