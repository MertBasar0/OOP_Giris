// See https://aka.ms/new-console-template for more information


class Sekil
{
    public int _en;
    public int _boy;

    public Sekil(int en, int boy)
    {
        _en = en;
        _boy = boy;
    }

    virtual public int AlanHesapla()
    {

    }
}

class Ucgen : Sekil
{
    public Ucgen(int en, int boy) : base(en,boy)
    {

    }
    public override void AlanHesapla()
    {
          
    }
}

class Diktortgen : Sekil
{
    public Diktortgen(int en, int boy) : base(en,boy) 
    {

    }

}

class Kare : Sekil
{
    public Kare(int en, int boy) : base(en,boy)
    {

    }
}


//Özet sanal yapılar OOP de poliformizm (çok biçimlilik) uygulanan yapıdır.

//Eğer bir class üyesi sanal olarak bildirilmiş ise ,derleyici nesnelerin tür bilgisinden faydalanarak derleme zamanında
//hangi nesneden ilgili üyenin çağırılacağını bilir.
   
//Ezmek istediğiniz yapı virtua ile işaretlenir..
//Türeyen sınıflarda sanal yapı ezmek için override keywordü kullanılır.
//Türeyen sınıflar sanal yapıları override etme zorunluluğu yoktur.

