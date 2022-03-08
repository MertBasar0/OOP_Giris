// See https://aka.ms/new-console-template for more information


//Bir nesne üzerinde var olan tüm memberların tamamı derleme zamanında belirgindir. 
//YAni derleme aşamasında hangi nesne üzerinde hangi mettıların çapıtılacağı bilinmektedir.
//Bir sınıfta tanımlanmış olan herhangi bir member'ın kendisinden türeyen alt sınıflarda name hidding durumuna düşmeksizin
//ezilip /yeniden yazılıp yapılandırılması durumudur.
//Peki zorunlu mudur??
//Yani sanal yapılar illa ki kendinden türeyen alt sınıflarda ezilmek zorunda değildir.
//Ama farklı bir lullanım söz konusudur. Farklı kodlar yazmak isterseniz ezebilirsiniz.



Obje b1 = new Obje();
b1.Bilgi();


//class MyClass
//{
//    virtual public void test
//    {

//    }

//    public virtual int MyProperty { get; set; }
//}
//class test : MyClass
//{
//    public override int MyProperty { get => base.MyProperty; set => base.MyProperty = value; }
//}


class Obje
{
    public virtual void Bilgi()
    {
        Console.WriteLine("ben bir objeyim");
    }
}

class Masa : Obje
{
    public override void Bilgi()
    {
        Console.WriteLine("ben bir masayım..");
    }
}

class Bilgisayar : Obje
{

}


//Bir class virtual ile işaretlenerek sanal hale getirilmiştir bir member (prop yada metot) bu class'tan miraz alan torunlarında ezilme/yeniden yazılmak
//isteniyorsa eğer ilgili classta override olarak işaretlenmelidir.


//ikiden fazla hiyerarşi bir kalıtım durumunda override
//bir class'ta virtual olarka işaretlenmiş herhangi bir member illa direk olarak class'tan türeyen 1. dereceden class'lar da override edilmek mecburiyetinde değilfir.
//ihtiya. durumunda alt seviyedeki torunlarda herhangi birine override edilebilir..
//Fakat dikkat etmeniz gereken bir durum var
//O da virtual olarak işaretlediğiniz soyun member son override edildiği object'den geçerli olduğudur.
//O Objeden sonra hiyerarşik olarak türetilen sınıflar varsa onlarda override işlemi gerçekleştirilebilir.