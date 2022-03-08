// See https://aka.ms/new-console-template for more information

Four f = new Four(4444);
public class One
{
    public int MyProperty { get; set; }
    public One(int a)
    {
        Console.WriteLine(a);
    }
}

public class Two :One
{
    public Two(int p) :base(p)
    {

    }
}

public class Tree : Two
{
    public Tree(int t) : base(t)
    {

    }
}

public class Four : Tree
{
    public Four(int k) : base (k) 
    {

    }
}
