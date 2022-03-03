// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Kalıtım OOP EN ÖNEMLİ ÖZELLİĞİDİR.
//Üretilen neneler farklı bir nesneye özelliklerini aktarabilmekte ve böylece aynı olan özellikleri tekrar tekrar yazmamızın önüne geçilmekte..
//Bir programcı açısında bu özellik =>>
//Aynı aile grubundan gelen nesnelerin yada yatayda olan tüm olguların benzer özelliklerini tekrar tekrar herbirinden tanımlanmaktansa
//üst sınıfta tanımlanması ve her bir alt sınıfa miraz yolu ile bu özelliklerin aktarılması olayıdır.
//Böylece hem kod maliyeti, hem de mimarisel açıdan tasarımsal açıdan avantaj saplanmaktadır.

Muhasebeci msb = new Muhasebeci();
Yazilimci yzl = new Yazilimci();

List<string> tt = new List<string>();
tt.Add("C#");
tt.Add("LabView");
yzl.KullandigiDiller= tt;




class Personel
{
    public string Adi { get; set; }
    public string Soyadi { get; set; }
    public bool MedeniHal { get; set; }
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
    
}

//Yukarıdaki her nesne için ayrı ayrı çalışan sınıflarınmı oluşturdum. Hepsi için ortak olan özellikler altında tekrar etti.
//Kalıtım kullanmadığım için sınıflarımın altı özellikler ortak olmasına ragmen gereksiz doldu..