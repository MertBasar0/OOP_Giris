// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Kisi kisi = new Kisi
{
    Isim = "BilgeAdam",
    Yas = 52
};

var(x,y) = kisi;


//Bir sınıf içerisinde Deconstruct ismiyle tanımlanan metot compiler tarafından özel olarak algılanmakta ve sınıf
//nesne üzerinden geriye hızlıca tuple bir değer dönmenizi sağlar.


class  Kisi
{
    public string Isim { get; set; }
    public int Yas { get; set; }

    public void Deconstruct(out string isim, out int yas)
    {
        yas = Yas;
        isim = Isim;
    }
}


class DB
{
    public string ConnectionString { get; set; }

}
//Sözlü mülakat için.






