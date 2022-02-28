// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



//Field nesne içerisinde değer tutmamızı sağlayan alanlardır.
//Class içerisindeki değişkenlerdir..
//Herhangi bir değişken class içerisnde field olarak tanımlanıyorsa default değeri verilir.
//Yok eğer class'taki değiş metot vs içerisinde tanımlanıyorsa default değer verilemez.

MyClass m1 = new MyClass(); //nesne tanımladık..

m1.a = 20;

MyClass m2 = new MyClass();

m2.a = 5;


class MyClass
{
    //Field nesne içerisinde değer tutmamızı sağlar..
    public int a;
    public string b;
}
