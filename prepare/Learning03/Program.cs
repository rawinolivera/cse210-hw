using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction const1 = new Fraction();
        Console.WriteLine(const1.GetFractionString());
        Console.WriteLine(const1.GetDecimalValue());

        Fraction const2 = new Fraction(5);
        Console.WriteLine(const2.GetFractionString());
        Console.WriteLine(const2.GetDecimalValue());

        Fraction const3 = new Fraction(3,4);
        Console.WriteLine(const3.GetFractionString());
        Console.WriteLine(const3.GetDecimalValue());

        Fraction const4 = new Fraction(1,3);
        Console.WriteLine(const4.GetFractionString());
        Console.WriteLine(const4.GetDecimalValue()); 
    }
}