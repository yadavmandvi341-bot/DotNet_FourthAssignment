using System;
class Program6
{
    delegate double MyDelegate(double Salary);

    static double Salary(double salary)
    { 
       
        Console.WriteLine("Basic = " + salary);
        return salary;  
        
    }
    static double HRASalary(double Salary)
    {
        double HRASalary = Salary * 0.2;
        HRASalary = HRASalary + Salary;
        Console.WriteLine("HRSalary = " +HRASalary);
        return HRASalary;

    }
    static double DASalary(double Salary)
    {
        double DASalary = Salary * 0.1;
        DASalary = DASalary + Salary;
        Console.WriteLine("DASalary = " + DASalary);
        return DASalary;
    }
    static double BonusSalary(double Salary) { 
        double BonusSalary = Salary * 0.15;
        BonusSalary = BonusSalary + Salary;
        Console.WriteLine("BonusSalary = " +BonusSalary);
        return BonusSalary;
    }
    public static void Main(String[] args)
    {
        Console.Write("Enter Salary: ");
        double bs = Convert.ToSingle(Console.ReadLine());
        MyDelegate del;
        del = Salary;
        del(bs);
        del = HRASalary;
        del(bs);
        del = DASalary;
        del(bs);
        del = BonusSalary;
        del(bs);
    }
}
