using System;

class Program7
{
    delegate void MyDelegate();

    static void Method1()
    {
        Console.WriteLine("Method 1 is called");
    }
    static void Method2()
    {
        Console.WriteLine("Method 2 is called");
    }
    static void Method3()
    {
        Console.WriteLine("Method 3 is called");
    }
    static void Main1()
    {
        MyDelegate del = Method1;
        del += Method2;
        del += Method3;

        Console.WriteLine("Methods stored in delegate:");

        foreach (Delegate d in del.GetInvocationList())
        {
            Console.WriteLine(d.Method.Name);
        }
        Console.WriteLine("\nInvoking methods individually:");
        foreach (Delegate d in del.GetInvocationList())
        {
            d.DynamicInvoke();
        }
    }
}
