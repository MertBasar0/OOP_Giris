// See https://aka.ms/new-console-template for more information


Sarap sarap1 = new Sarap();
sarap1.Marka = "yeni rakı";

sarap1.UzumTuru = "beyaz";
Console.WriteLine(sarap1.AlkolOranı + sarap1.Marka + sarap1.UzumTuru + sarap1.KullanıldığıKokteyller);



public class Alkol
{
    public string Marka { get; set; }
    public int AlkolOranı { get; set; }
    public int Fiyat { get; set; }
    public string KullanıldığıKokteyller { get; set; }
}

public class Bira : Alkol
{
    
}

public class Sarap : Alkol  
{

    private string tur;
    public string UzumTuru
    {
        get
        {      
            return tur = "kırmızı";

        }
        set
        {   
            tur = value;

        }
    }

    private int myVar;

    public int MyProperty
    {
        get { return myVar; }
        set { myVar = value; }
    }


    public Sarap()
    {
        Marka = "Doluca";
        AlkolOranı = 15;
        Fiyat = 30;
        KullanıldığıKokteyller = "white russian";
    }
       
}


public class Viski :Alkol
{

}

public class Votka : Alkol
{

}
