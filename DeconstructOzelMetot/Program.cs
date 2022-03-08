// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Kisi kisi = new Kisi
{
    Isim = "BilgeAdam",
    Yas = 52
};

var(x,y) = kisi;
Console.WriteLine($"{x}  {y}");


//Bir sınıf içerisinde “Deconstruct” ismiyle tanımlanan metot, compiler tarafından özel olarak algılanmakta
//ve sınıfın nesnesi üzerinden geriye hızlıca Tuple tipte bir değer döndürmemizi sağlamaktadır.
//Tuble =>> bir dizi cinsidir..

class Kisi
{
    public string Isim { get; set; }
    public int Yas { get; set; }

    public void Deconstruct(out string isim, out int yas)
    {
        
        isim = Isim;
        yas = Yas;
    }
}

//Sözlü mülakat için.

 




