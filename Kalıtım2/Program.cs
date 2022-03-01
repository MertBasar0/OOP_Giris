// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Eğer B objesinden bir nesne oluşturmak istenirse.


new D();

//Önce compile arka tarafta a'dan bir nesne oluşturur.
//ardından istenirse b nesnesi oluşur.


//Base class : Kalitim veren sınıf..
//Kalıtım alan sınıfa Derived /child class denir.
//Bir sınıfın sadece ve sadece bir adet base classı olabilir.
//Yani bir sınıfın base classı direk olarak türedü sınıftır.
//Bir classın birden fazla vhild classı olabilir.
//c# programlama dilinde bir class'ın sade sadece tek bir classtan türemesine izin verilmektedir !!
//Aynı anda birden fazla classda türeme işlemi gerçekleşmez..

#region Coklu
class A
{
    public A(int a)
    {
        Console.WriteLine($"{nameof(A)} Nesnesini oluşturmuştur.. ");
    }
}
class B : A
{
    public B() : base(5)
    {
        Console.WriteLine($"{nameof(B)} Nesnesini oluşturmuştur.");
    }
}
class C : B
{
    public C()
    {
        Console.WriteLine($"{nameof(C)} Nesnesini oluşturmuştur. ");
    }
}
class D : C
{
    public D()
    {
        Console.WriteLine($"{nameof(D)} Nesnesini oluşturmuştur.");
    }
}
#endregion


class MyClass
{
    public MyClass(int a)
    {
        Console.WriteLine(a);
    }
}
class MyClass2 : MyClass
{
    public MyClass2() : base(5) // Miras aldığım sınıfın ctor 'deger gönderme işlemini burdaki base keywordü ile sağlıyorum.'
    {

    }
    public MyClass2(int z) :base(z)
    {

    }
}
//Kalıtım nesne üretim sırası..
//Yukarıdaki örnekte D clasını heap'de oluşturmak istedik. Bu isteğimiz doğrultusunda d sınıfına bağlı olan üst sınıflar üzerinden sırası
//öncelikle a sonrasında b ve c olduğunu en son ise istediğimiz d sınıfını new'lediğini fark ettik.


//Bir sınıftan base class cont nasıl ulaşırız..

//Base Keyword vs this keyword

//This'le, bir sınıftaki ctorlar arasında geçiş yapamazsınız.
//Base, bir sınıfın base class'ının ctorlarından hangisinin tetikleneceğini belirtmemize ve varsa parametre göndermenize olanak sağlar.


//Ayrıca nasıl ki this, ilgili sınıftaki o an ki üzerinde bulunan nernelerin ütelerine erişmemizi sağlırsa,
//aynı şekilde base' de base vlassdami memberlara erişim sağlayabilirsiniz.