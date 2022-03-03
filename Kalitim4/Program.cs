// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


D d = new D();
d.x();



class A
{
    public void x()
    {

    }
}

class B : A
{

}

class C : B
{

}

class D : C
{
    public new void x() // new ile belirttim.
    {

    }

    //Name Hidding ve new operatörü ile işaretleme
    //Miras alan alt sınıf kullanılan bir değişken ismi o sınıfın base class'ında da aynı isimle kullanılıyorsa compile isim gizleme özelliğini
    //devreye sokar. Base classdaki isim gizleme özelliği eskiden bulunmazlardı.Bulunmadıkları için de illa new ile belirtmeniz gerekirdi.
    //Belirtmezsenizde uyarı değil hata alırdınız.. Fakat artık şimdi uzak olanı gizleyip yakın olanı size açar ve sadece bu yaptığı işlem hakkında
    //size bilgi verir.
}



//Record 'larda kalıtım.
//Classlardan recordlaar kalıtım alamazsınız.
//base ve this kullanımı burada da geçerli.


record z
{

}

record q:z
{

}