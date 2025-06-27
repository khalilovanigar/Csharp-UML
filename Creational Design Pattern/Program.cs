using System;
interface IProduct
{
    string DoStuff();
}

class ConcreteProductA : IProduct
{
    public string DoStuff()
    {
        return "Product A worked";
    }
}

class ConcreteProductB : IProduct
{
    public string DoStuff()
    {
        return "Product B worked";
    }
}

abstract class Creator
{
    public abstract IProduct CreateProduct();

    public void SomeOperation()
    {
        IProduct product = CreateProduct();
        Console.WriteLine(product.DoStuff());
    }
}

class ConcreteCreatorA : Creator
{
    public override IProduct CreateProduct()
    {
        return new ConcreteProductA();
    }
}

class ConcreteCreatorB : Creator
{
    public override IProduct CreateProduct()
    {
        return new ConcreteProductB();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Creator creatorA = new ConcreteCreatorA();
        creatorA.SomeOperation();

        Creator creatorB = new ConcreteCreatorB();
        creatorB.SomeOperation();
    }
}