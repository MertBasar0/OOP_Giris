// See https://aka.ms/new-console-template for more information


//OOP' de cok biçimlilik iki ya da daha fazla nesnenin aynı tür sınıf tarafından karşılanabilir referans edilebilir olmalıdır.

//Bir başka değişle bir nesneyi birden fazla türdeki referans ile işaretleme olayıdır.

//Polimorfizm, oop de tasarımsal açıdan kodda daha manevrasal bir şekilde ntelik kazandıran bir yaklaşımdır.
//Polimorfizm, programlamada ki temel prsnsibi sağ sol kuralını aşıp eldeki nesnenin birden fazla referansla tutulması olayı.


//Kuş => Papağan mı?, deve kuşu mu?, muhabbet kuşu? tavuk /penguen ? 
//Kuş cinsinden olan tüm hayvanların kendi türlerinin  dışında bir yandan bunlara kuş tarifi yapıldığını anlıyorsunuz.
//Peki kuş olmayana zaten kuş demiyoruz mesela maymun kuş değil

//Burada  şu sonuca varırız ortak atadan gelen, kalıtımsal olarak kuştan türeyen tüm hayvanlar kendi türleri yahut kuş türleri ile
//referans ediilebilir..

MyClass my = new MyClass2();


class MyClass
{

}

class MyClass2 : MyClass
{

}