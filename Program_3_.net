using System;

class Program3
{
    delegate void MyDelegate();

    static void Method1()
    {
        Console.WriteLine("Method 1");
    }

    static void Method2()
    {
        Console.WriteLine("Method 2");
    }

    public static void Main1()
    {
        MyDelegate d1 = Method1;

        Console.WriteLine("Unicast Delegate:");
        d1();

        MyDelegate d2 = Method1;
        d2 += Method2;

        Console.WriteLine("\nMulticast Delegate:");
        d2();
    }
}
