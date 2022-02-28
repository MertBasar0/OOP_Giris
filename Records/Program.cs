 // See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


class MyClass
{
    public int MyProperty { get; } // readonly
}


MyClass m1 = new MyClass()
{
    m1.MyProperty = 50; //Hata verecektir.
};

MyClass2 m2 = new MyClass2()
{
    MyProperty = 60
};

class MyClass2
{
    public int MyProperty { get; init; }
}

//c# 9.0 üzerinde herhangi bir nesnenin property değerlerine ilk değer verilmesi ve sonraki süreçte bu değerin
//değiştirilmesmesinin garanti altına alınmasını bildiren init-only prop özelliğidir.

//Bu özellik sayesinde nesnenin sadece ilk yaradılış anında prop değer atanmakta ve
//böylece iş kuralları gereği runtime'da değeri değiştirilmemesi gereken nesneler için ideal bir önlem olacaktır.



//peki=>> init only prop ger only prop arasındaki fark ne
//get only proplarda nesneyi new'leme asnasında object initializer ile değer ataması yapamıyorsunuz.
//Zaten bu eksik fark edildiğinden dolayı init only prop geliştirilmiştir.





//Records nedir ? 

//C# 9.0 ile gelmiştir. int only prop özelliği, nesne üretim esnasının dışında değişmezler değerler oluşturması
//için ctor (yapıcı metot) ve auto prop initializers yapısının yanında object initializer yapısının kullanılabilir olmasını sağlar.


record MyRecord
{
    public int MyProperty { get; set; }
}

class MyClass3
{
    public int MyProperty { get; set; }
}


MyClass3 m15 = new MyClass3()
{
    MyProperty = 5
};
MyClass3 m16 = new MyClass3()
{
    MyProperty=5
};

Console.WriteLine(m15.Equals(m16)); // False değer döner çünkü heap alanındaki yerleri üzerinden karşılaştırma yapar.

MyRecord m17 = new MyRecord { MyProperty = 5 };
MyRecord m18 = new MyRecord { MyProperty = 5 };

Console.WriteLine(m17.Equals(m18)); // True döner çünkü değer üzerinden karşılaştırma yapar.


