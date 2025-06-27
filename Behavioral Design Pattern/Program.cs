using System;

public interface IClient
{
    void DoSomething();
}

class Client
{

}

class Adapter : IClient
{
    public void DoSomething()
    {

    }
}

class Service
{
    public void DoService()
    {
        Console.WriteLine("Do Service is worked");
    }
}


class Program
{
    static void Main(string[] args)
    {

    }
}