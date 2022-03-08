// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



int sayi = 100;
while(sayi >= 1)
{
    new MyClass2(sayi--);
    Console.WriteLine("-------------------------------");
    GC.Collect();
}

////GC garbage collector'a ulaşmak için kullandığımız sınıftır.


static void x()
{
    MyClass m = new MyClass();
}



class MyClass
{

    public MyClass()
    {
        Console.WriteLine("constructor çalıştı..");
    }

    ~MyClass()
    {
        Console.WriteLine("Nesne yıkıldı..");
    }
}


class MyClass2
{
    int no;
    public MyClass2(int no)
    {
        this.no = no;
        Console.WriteLine($"{no} nesne oluşturuluyor..");

    }
    ~MyClass2()
    {
        Console.WriteLine("silindi..");
    }
}

//Bir nesne neden imha edilir.
//İlgili nesne herhangi bir referans tarafından işaretlenmemelidir.
//Yada nesnenin oluşturulduğu scope sona ermiş olmalıdır.
//Yani ilgili nesneye bir daha erişilmez hale gelmelidir.
//Destructor tanımlayabilmek için tilde kullanılır.
//Yıkıcı metot yapıcı metot gibi class adi ile aynı ada sahip ve geri dönüş değeri yok.
//Bu yapının amacı nesne silinirken yaptırmak istediğiniz son bir işlem varsa yaptırıp nesneye veda etmeniz için kullanılan özel bir fonksiyondur.

//Garbage Collector


//Uygulama içerisinde var olan lüzumsuz nsneleri toplar(çöp toplayıcısı)
//Esasında GC C# Bellek optimizasyonu üstüne bir yapılanmadır.
//C#'da gc'nin ne zaman iş göreceğini anlamak kesin değildir. Kafasına göre çalışır..
//Dolayısıyla bu yapıya manuel müdehale önerilmez..




