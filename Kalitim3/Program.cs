// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



class A
{
    int a;
    public int b;
    public int MyProperty { get; set; }
}

class B : A
{
    int c;
    public void X(int c)
    {
        //this.a =>> erişemem çünkü erişim bildirgecim private buna müsade etmiyor.
        //base.a =>> desemde erişemem çünkü private.
        //this.c // ile B class'ındaki c ye erişim sağlarız. Düz 'c' yazıldığında fonksiyonun parametresi olan 'c' ye ulaşabilirliz.
    }
}