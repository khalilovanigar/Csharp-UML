using System;

public interface IClient
{
    void Method(string data);
}

public class Service
{
  public void ServiceMethod(string specialData)
    {
        Console.WriteLine($"Service is worked: {specialData}");
    }
}


class Adapter : IClient
{
    
    Service service = new Service(); 

    public void Method(string data)
    {
        string specialData = "Adapted: " + data;
        service.ServiceMethod(specialData);
    }
}

public class Client
{
    public void DoSomething(IClient service)
    {
        service.Method("Client is doing something");
    }
}



class Program
{
    static void Main(string[] args)
    {
        IClient adapter = new Adapter();
        Client client = new Client();
        client.DoSomething(adapter);

    }
}
