using System;
class Program2
{
    delegate float MyDelegate(float a, float b);

    static float Add(float a, float b)
    {
        Console.WriteLine(a + b);
        return a + b;
    }
    public static void Main1(string[] args)
    {
        float num1 = Convert.ToSingle(Console.ReadLine());
        float num2 = Convert.ToSingle(Console.ReadLine());

        MyDelegate del = new MyDelegate(Add);
        del(num1, num2);
    }
}
