// See https://aka.ms/new-console-template for more information


Inek my = new Inek();
my.Konus();
memeli mt = new memeli();
mt.Konus();


class memeli
{
    virtual public void Konus()
    {
        Console.WriteLine("Konuşuyorum");
    }

}
class Maymun : memeli
{
    public override void Konus()
    {
        Console.WriteLine("ahahahahaıagajgsşjgasj Konuşuyorum");
    }
}
class Inek : memeli
{
    public override void Konus()
    {
        Console.WriteLine("möööööööööööö konuşuyorum..");   
    }
}