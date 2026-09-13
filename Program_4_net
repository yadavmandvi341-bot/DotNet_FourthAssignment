using System;

class Program4
{
    delegate int MyDelegate(int a, int b);
    static int Add(int a, int b)
    {
        return a + b;
    }
    static int Subtract(int a, int b)
    {
        return a - b;
    }
    static int Multiplication(int a, int b)
    {
        return a * b;
    }
    static int Division(int a, int b)
    {
        return a / b;
    }
    public static void Main1(string[] args)
    {
        Console.Write("Enter a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        MyDelegate del;
        del = Add;
        Console.WriteLine("Addition = " + del(a, b));
        del = Subtract;
        Console.WriteLine("Subtraction = " + del(a, b));
        del = Multiplication;
        Console.WriteLine("Multiplication = " + del(a, b));
        del = Division;
        Console.WriteLine("Division = " + del(a, b));
    }
}
