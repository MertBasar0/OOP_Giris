// See https://aka.ms/new-console-template for more information



//DataBase database1 = DataBase.GetInstance;
//DataBase database2 = DataBase.GetInstance;
//DataBase DataBase3 = DataBase.GetInstance;

//database1.ConnectionString = "ConnectionString";



//class DataBase
//{
//    DataBase() //Dışarıdan newleme isteklerini sonuçlandırmaması içindir.
//    {

//    }

//    public  string ConnectionString { get; set; }

//    static DataBase database; //Referansın stack de tutulmasını sağladık.

//    static public DataBase GetInstance//Stack const sınıfın içerisinde oludğumuz için burda üretilen nesneyi database prop'ne geri döndm.
//    {
//        get
//        {
//            return database;
//        }
//    }

//    static DataBase()
//    {
//        database = new DataBase();//Static const sayesinde uygulama ilk kez ayağa kalktığında database static const
//                                  //bir kere newler bir daha program bitene kadar çalışmaz.
//    }
//}




//class MyClass
//{
//    public MyClass()
//    {
//        //Bu sınıf nesne üretilirken ilk tetinlencek olan metotdur.
//        Console.WriteLine("myclassin ctor çalıştı.");
//    }
//    static MyClass()
//    {
//        //Bu sınıftan ilk nesne üretilirken tetiklenecek olan metotdur.
//        //Üretilen ilk nesne dışında bir daha tetiklenmez..
//        //Static ctor tetiklenmesi için illa bir nesne üretimine gerek yoktur.
//        //İlgili sınıf içerisinde herhangi bir static yapılanmanın tetiklenmesi static ctor tetiklenmesini sağlar.
//        Console.WriteLine("static ctor tetiklendi.");
//    }
//}