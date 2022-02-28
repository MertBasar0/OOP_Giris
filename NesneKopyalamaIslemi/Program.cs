// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



//Kopyalama işlemlerinde iki davranış vardır. 

//Deep Copy =>> değeriyle birlikte kopyalar.
//Shallow Copy =>> referans yolunu kopyalar.


//Deep copy 
//Değer türlü değişkenlerde defeult olarak kullanılan kopyalama yöntemidir.
//Car olan bir nesne deep copy ile kopyalanırsa eğer ilgili 


class MyClass
{

    public MyClass DeepKopyala()
    {
        return (MyClass)this.MemberwiseClone();
    }

}

MyClass m1 = null;
MyClass m2 = new MyClass();
MyClass m3 = m2;
m1 = m3;


int a = 6;
int b = a;
int c = b;



Console.WriteLine(c);


MyClass m11 = new MyClass();
MyClass m12 = m11; //Shallow
MyClass m13 = m11.DeepKopyala(); // Deep copy yaptı. 

