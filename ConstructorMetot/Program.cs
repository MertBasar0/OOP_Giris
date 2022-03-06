// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


    //Constructor bir nesne üretme sürecinde ilk tetiklenen metotdur.


    

    //Constructor bir nesne üretimi sürecinde ilk çalışan metot olup nesne oluşturma sürecinde tetiklenmek zorundadır.
    //Constructor new ile nesne yaratma talebi geldikten sonra ilgili nesneye hafızada yer ayrıldıktan sonra tetiklenir.
    //Nesnelerin ilk anındaki field'lara ilk değerini atamakla yükümlüdür.
    //ctor, özel bir sınıf elemanıdır. 
    //özel bir yapı olsada bir metotdur.
    //fakat bildiğiniz metotlardan farklı davranış sergilerler.
    //Sınıf adı ile aynı adı alırlar.
    //Geri dönüş tipleri olmaz.
    //Erişim bildirgeci public olmalıdır.
    //İstistai durumlarda private da olur.
    //Singletion desing pattern kullanımında privare olur.


MyClass5 m5 = new MyClass5(2,4);


class MyClass
{
    
    public MyClass()
    {
        Console.WriteLine("ilk tetiklenmede çalışır..");
    }
    public MyClass(int a) //Metot overload
    {
        Console.WriteLine($"birinci overload çalıştı {a}");
    }
    public MyClass(string a) //Metot overload
    {
        Console.WriteLine($"ikinci overload çalıştı..{a}");
    }
    //bir sınıfın cons metotdu varsa isim class ismiyle aynı olmalıdır. Dönüş tipi olmamalıdır.
    //diğer metotlar gibi aşırı yükleme yapılabilir.
}



class MyClass2
{
    public int a, b;
    public MyClass2(int a, int b)
    {
        this.a = a;
        this.b = b;
    }
    public void topla ()
    {
        int sonuc =a + b;
        Console.WriteLine(sonuc);
    }
}

//This keyword'ü ile ctor'lar arasındaki ilişki.

class MyClass5
{
    public MyClass5()
    {
        Console.WriteLine("1.Ctor");
    }
    public MyClass5(int a) 
    {
        Console.WriteLine("2. Ctor"+a);
    }
    public MyClass5(int a, int b) : this() // This() keyword ü ile diğer Ctor'ları da çalıştırmak istiyorsanız parametre sayısına göre this'in içini doldurmalısınız.
    {
        Console.WriteLine("3.Ctor"+a+" "+b);
    }
}

//Eğer bir Ctor metot tetiklendiğinde diğer Ctor metotlarıda tetiklenmesini istiyorsanız this() şeklinde belirtmeniz gerekir.


//This ile birlikte kullandığımız const dışında yapıcı metotlar tetikleyebiliriz. Parametrelerine erişebiliriz.
//Diğer metotlarada this keywordü ile erişim sağlamanız mümkündür.

