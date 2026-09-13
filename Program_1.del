using System;
class Program
{
    delegate void MyDelegate(string message);

    static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
    static void Main1(string[] args)
    {
        MyDelegate del = new MyDelegate(ShowMessage);
        del("Hello Delegate!");
    }
}
