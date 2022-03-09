// See https://aka.ms/new-console-template for more information


q m = q.Instance;



//MyClass m = new MyClass();  
//MyClass m1 = new MyClass(); 
//MyClass m2 = new MyClass();
//class MyClass
//{
//    public MyClass()
//    {
//        //bu sınıf nesne üretilirken oluşacak ilk metotdur.
//        Console.WriteLine("myclass ctor çalıştı..");
//    }

//    static MyClass()
//    {
//        //bu sınıftan ilk nesne üretilirken tetiklenecek olan metotdur.
//        //Üretilen ilk nesne dışında bir daha tetiklenmez.
//        //static ctor tetiklenmesi için illa bir nesne üretimine gerek yoktur..
//        //ilgili sınıf içerisinde herhangi bir static yapılanmanın tetiklenmesi static ctor tetiklenmesini sağlar.

//        Console.WriteLine("static ctor tetiklendi..");
//    }
//}


class Database
{
    Database() //dışarıdan newleme isteklerini alamaması için erişim bildirgeci(public)i sildim.
    {

    }
    public string ConnnectionString { get; set; }

    static Database database;

    static public Database GetInstance
    {
        get
        {
            return database;
        }
    }

    static Database()
    {
        database = new Database();
    }
}




class q
{

    static q instance;

    public static q Instance
    {
        get { return q.instance; }
    }

    static q()
    {
        instance = new q();
    }
    
}


