using System;

class Program8
{
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
        Action action1 = Method1;
        Console.WriteLine("Unicast Action:");
        action1();
        Action action2 = Method1;
        action2 += Method2;
        action2 += Method3;
        Console.WriteLine("\nMulticast Action:");
        action2();
    }
}
