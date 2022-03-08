// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

MyClass m1 = new MyClass()
{
    MyProperty = 20,
    MyProperty2 = 30,
    MyProperty3 = 40,
    MyProperty4 = 50,
    MyProperty5 = 60
    
};


//Bu şekilde new'leme işlemi esnasında object initializer yöntemi kullanarak prop'larda başlangıç değeri
//aranarak nesne oluşturulur. Diğer türlü nesne oluşturmada prop içerisindeki değerler default olarak gelir.
class MyClass
{
    public int MyProperty { get; set; }
    
    public int MyProperty2 { get; set; }
    
    public int MyProperty3 { get; set; }
    
    public int MyProperty4 { get; set; }
    
    public int MyProperty5 { get; set; }

}