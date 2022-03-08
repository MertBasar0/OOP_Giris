// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");




//new D();


//Eğer B objesinden bir nesne oluşturmak istenirse.
//Önce compile arka tarafta a'dan bir nesne oluşturur.
//ardından istenirse b nesnesi oluşur.


//Base class : Kalitim veren sınıf..
//Kalıtım alan sınıfa Derived /child class denir.
//Bir sınıfın sadece ve sadece bir adet base classı olabilir.
//Yani bir sınıfın base classı direk olarak türediği sınıftır.
//Bir classın birden fazla child classı olabilir.
//c# programlama dilinde bir class'ın sade sadece tek bir classtan türemesine izin verilmektedir !!
//Aynı anda birden fazla classda türeme işlemi gerçekleşmez..

#region Coklu
//class A
//{
//    public A(int a)
//    {
//        Console.WriteLine($"{nameof(A)} Nesnesini oluşturmuştur.. ");
//    }
//}
//class B : A
//{
//    public B(int c, int d) :base()
//    {
//        Console.WriteLine($"{nameof(B)} Nesnesini oluşturmuştur.");
//    }
//}
//class C : B
//{
//    public C() : base(5,6)
//    {
//        Console.WriteLine($"{nameof(C)} Nesnesini oluşturmuştur. ");
//    }
//}
//class D : C
//{
//    public D()
//    {
//        Console.WriteLine($"{nameof(D)} Nesnesini oluşturmuştur.");
//    }
//}
#endregion

MyClass3 m = new MyClass3(40);
class MyClass
{
    public MyClass(int a)
    {
        Console.WriteLine(a+40);
    }
}
class MyClass2 : MyClass
{
    public MyClass2() : base(5) // Miras aldığım sınıfın ctor 'deger gönderme işlemini burdaki base keywordü ile sağlıyorum.'
    {
        int a = 5;
    }
    public MyClass2(int z,int o) :base(z)
    {
        int k = z;
        Console.WriteLine(k+5);
    }
}
class MyClass3 : MyClass2
{
    int b = 15;
    public MyClass3(int c) :base(10,15)
    {

    }
}
//Kalıtım nesne üretim sırası..
//Yukarıdaki örnekte D clasını heap'de oluşturmak istedik. Bu isteğimiz doğrultusunda d sınıfına bağlı olan üst sınıflar üzerinden sırası
//öncelikle a sonrasında b ve c olduğunu en son ise istediğimiz d sınıfını new'lediğini fark ettik.


//Bir sınıftan base class contructor nasıl ulaşırız..

//Base Keyword vs this keyword

//This'le, bir sınıftaki ctorlar arasında geçiş yapamazsınız.
//Base, bir sınıfın base class'ının ctorlarından hangisinin tetikleneceğini belirtmemize ve varsa parametre göndermenize olanak sağlar.


//Ayrıca nasıl ki this, ilgili sınıftaki o an ki üzerinde bulunan nernelerin ütelerine erişmemizi sağlırsa,
//aynı şekilde base' de base vlassdami memberlara erişim sağlayabilirsiniz.