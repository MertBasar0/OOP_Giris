// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


//Ram'in stack bölgesinde tanımlanan ve heap bölgesinde nesneleri işaretleyen, Refere eden değişkenlerdir.

//int, double, float, vs vs value type değişkenler.
//Stack bölümünde yukarıda yazılan değişken tipleriyle değerleri bir arada tutulur.

//Class, interface, abstract, record'lar referans tiplerdir.

//Bu yapılar class hariç newleme işlemi gerçekleştiremezler. Fakat RAM'İN HEAP BÖLGESİNE İŞARETLEME YAPABİLİRLER.
//Bu nedenle abstract, interface gibi nesneler new keywordü ile birlikte kullanılamazlar.


MyClass m2 = null;
m2.MyProperty = 80;

Console.WriteLine(m2.MyProperty);



class MyClass
{
    public int MyProperty { get; set; } //////////SALI GÜNÜNDE KALDIN......../////////
}



//luzumsuz yer kaplayacaüondan dolayı bir süre sonra garbage collecror denilen çöp toplayıcılar tarafından temizlenecektir.
//Herhangi bir işaret eden referans olmadığından dolayı luzumsuz yer kaplayacağından dolayı bir süre sonra gb denilen çöp
//toplayıcılar temizler.
//Referanssız nesneye sadece tanımladığınız yerde erişim sağlarsınız.

//GC (garvace collector): Heap'de referanssız olan nesne imha etmekten temizlemekten sorumlu bir yapıdır..
