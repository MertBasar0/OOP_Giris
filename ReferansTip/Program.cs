// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



//luzumsuz yer kaplayacaüondan dolayı bir süre sonra garbage collecror denilen çöp toplayıcılar tarafından temizlenecektir.
//Herhangi bir işaret eden referans olmadığından dolayı luzumsuz yer kaplayacağından dolayı bir süre sonra gb denilen çöp
//toplayıcılar temizler.
//Referanssız nesneye sadece tanımladığınız yerde erişim sağlarsınız.

//GC (garvace collector): Heap'de referanssız olan nesne imha etmekten temizlemenren sorumlu bir yapıdır..



//ram'in stack bölgesinde tanımlanan ve heap bölgesinde nesneleri işaretleyen Referans eden değişkenlerdir.
//int, double dloat vs vs calıur type değişkenler.
//stack bölümünde yukarıda yazılan değişken tiplerinin kendileri ile değerleri bir arada tutulur.
//class, interface, absract, record =>> Bunlar referans tiplerdir.
//Bu yapılar class hariç new'leme işlemi gerçekleştirmezler. Fakat ram'in heap bölgesine işaretleme yapabilirler. 
//Bu nedenle avstract, interface gibi nesneler new keywordü ile birlikte kullanılamazlar.



