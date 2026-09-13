using System;

class Program10
{
    static bool IsEven(int n)
    {
        return n % 2 == 0;
    }

    static bool IsPositive(int n)
    {
        return n > 0;
    }

    static bool IsGreaterThan100(int n)
    {
        return n > 100;
    }

    static void Main()
    {
        Predicate<int> check = IsEven;

        Console.WriteLine("Unicast Predicate:");
        Console.WriteLine("Is Even: " + check(120));

        Predicate<int> checks = IsEven;
        checks += IsPositive;
        checks += IsGreaterThan100;

        Console.WriteLine("\nMulticast Predicate:");

        foreach (Delegate d in checks.GetInvocationList())
        {
            bool result = (bool)d.DynamicInvoke(120);
            Console.WriteLine(d.Method.Name + " = " + result);
        }
    }
}
