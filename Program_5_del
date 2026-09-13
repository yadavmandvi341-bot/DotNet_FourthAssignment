using System;
class Program5
{
    delegate void MyDelegate();
    static void Email()
    {
        Console.WriteLine("Email");
    }
    static void SMS()
    {
        Console.WriteLine("SMS");
    }
    static void WhatsApp()
    {
        Console.WriteLine("WhatsApp");
    }
    public static void Main()
    {
        MyDelegate del = new MyDelegate(Email);
        Console.WriteLine("Email Notification");

        del+= SMS;
        Console.WriteLine("SMS Notification");

        del += WhatsApp; 
        Console.WriteLine("WhatsApp Notification");
    }
}
