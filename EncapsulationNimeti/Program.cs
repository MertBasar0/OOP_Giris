// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



MyClass m = new MyClass();
m.ASet(15);
Console.WriteLine(m.AGet());


//Encapsulation,nesnelerimizde ki field'ların kontrollü bir şekilde dışarıya açılmasıdır..
//Bir başka değişle bakacak olursak nesnelerimizi başkalarını yanlış kullanımlarından korumuş oluyoruz.


//Nasılki bir motorun tüm parçalaırını kaporta koruyorsa class fieldlarını da kapsülleme yaparak koruruz.


class MyClass
{
    public int MyProperty { get; set; } // prop kullanımı

    int a; // Eski tip kullanım

    public int AGet()
    {
        return this.a/2;
    }
    public void ASet(int value)
    {
        this.a = value;
    }


    //FULPROP

    //private int myVar;

    //public int MyProperty
    //{
    //    get { return myVar; }
    //    set { myVar = value; }
    //}

}