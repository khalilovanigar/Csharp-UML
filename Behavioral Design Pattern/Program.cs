using System;

public interface IHandler
{
    IHandler SetNext(IHandler handler);
    void Handle(string request);
}

public class BaseHandler : IHandler
{
    private IHandler next;

    public IHandler SetNext(IHandler handler)
    {
        next = handler;
        return handler;
    }

    public virtual void Handle(string request)
    {
        if (next != null)
        {
            next.Handle(request);
        }
        else
        {
            Console.WriteLine("No one handle this request");
        }
    }
}

public class HandlerA : BaseHandler
{
    public override void Handle(string request)
    {
        if (request == "A")
        {
            Console.WriteLine("Handler A accepted the request");
        }
        else
        {
             base.Handle(request);
        }
    }
}
public class HandlerB : BaseHandler
{
    public override void Handle(string request)
    {
        if (request == "B")
        {
            Console.WriteLine("Handler B accepted the request");
        }
        else
        {
            base.Handle(request);
        }

    }
}

public class HandlerC : BaseHandler
{
    public override void Handle(string request)
    {
        if (request == "C")
        {
            Console.WriteLine("Handler C accepted the request");
        }
        else
        {
             base.Handle(request);
        }

    }
}

class Program
{
    static void Main()
    {
        IHandler h1 = new HandlerA();
        IHandler h2 = new HandlerB();
        IHandler h3 = new HandlerC();

        h1.SetNext(h2);
        h2.SetNext(h3);

        h1.Handle("A"); 
        h1.Handle("B");
        h1.Handle("C"); 
    }
}
