// See https://aka.ms/new-console-template for more information


//RECORDS

Myrecord m4 = new Myrecord()
{
    MyProperty = 4
};

Myrecord m5 = new Myrecord()
{
    MyProperty = 4
};


Console.WriteLine(m4.Equals(m5)); //Records'lar VALUE TYPE oldukları için karşılaştırma da tuttukları değer üzerinde yapılır.
                                  //Bundan dolayı TRUE döner.


MyClass2 m1 = new MyClass2()
{
    MyProperty = 5
};

MyClass2 m2 = new MyClass2()
{
    MyProperty = 5
};


Console.WriteLine(m1.Equals(m2)); // HEAP de bulundukları yer üzerinden karşılaştırma yapıldığı için FALSE dönecektir.




record Myrecord
{
    public int MyProperty { get; set; }
}





//MyClass m = new MyClass()
//{
//    MyProperty = 40 //hata verecektir.
//};


//MyClass2 m2 = new MyClass2()
//{
//    MyProperty =40 //init sayesinde oluşturulma esnasında değer aldı ve sonraki süreçte değer atamasına kapandı.
//};
//m2.MyProperty = 30;


//c# 9.0 üzerinde herhangi bir nesnenin prop değerlerine ilk değer verilmesi ve sonraki süreçte bu değerin değiştirilmeme garantisini veren init-only prop özelliğidir.
//Bu özellik sayesinde nesnenin sadece yaradılış anında prop atanmakta ve böylece iş kuralları gereği runtime' da  değerin değiştirilmemesi gereken nesneler için uygun bir önlem olacaktır.

//peki ==> init only prop get only arasındaki fark ne;
//get only proplarda nesneyi newleme esnasında object initializer ile değer ataması yapamıyorsunuz.
//Zaten bu eksik fark edildiğinden dolayı init only prop geliştirilmiştir.
class MyClass
{
    public int MyProperty { get; }
}


class MyClass2
{
    public int MyProperty { get; init; }
}

//records nedir ? 
//C# 9.0 ile gelmiştir. İnit only prop özelliği, nesne üretimi dışında değişmez
//değerler oluşturması için ctor ve outo initializers yapısının yanında object
//initializer yapısının kullanılabilir olmasını sağlar.

//Recordlar bir objenin topyekün sabit / değişmez kalmasını sağlamakta ve bu olayı
//güvence altına almakla yükümlüdür.


