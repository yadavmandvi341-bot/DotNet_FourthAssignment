using System;

class Program9
{
    static int Add(int a, int b)
    {
        return a + b;
    }

    static int Multiply(int a, int b)
    {
        return a * b;
    }

    static int Subtract(int a, int b)
    {
        return a - b;
    }

    static void Main1()
    {
        Func<int, int, int> func1 = Add;

        Console.WriteLine("Unicast Func:");
        Console.WriteLine("Addition = " + func1(10, 5));

        Func<int, int, int> func2 = Add;
        func2 += Multiply;
        func2 += Subtract;

        Console.WriteLine("\nMulticast Func:");

        foreach (Delegate d in func2.GetInvocationList())
        {
            int result = (int)d.DynamicInvoke(10, 5);
            Console.WriteLine(d.Method.Name + " = " + result);
        }
    }
}
