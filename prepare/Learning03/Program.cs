using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction _fraction1 = new Fraction();
        Console.WriteLine(_fraction1.GetFractionString());
        Console.WriteLine(_fraction1.GetDecimalValue());
        
        Fraction _fraction2 = new Fraction(5);
        Console.WriteLine(_fraction2.GetFractionString());
        Console.WriteLine(_fraction2.GetDecimalValue());

        Fraction _fraction3 = new Fraction(3, 4);
        Console.WriteLine(_fraction3.GetFractionString());
        Console.WriteLine(_fraction3.GetDecimalValue());

        Fraction _fraction4 = new Fraction(1, 3);
        Console.WriteLine(_fraction4.GetFractionString());
        Console.WriteLine(_fraction4.GetDecimalValue());

        
    }
    // {
    //     // Fraction f = new Fraction();
    //     // f.SetTopNumber(5);

    //     // f.SetBottomNumber(7);


    //     // Console.WriteLine(f.GetTopNumber());
    //     // Console.WriteLine(f.GetBottomNumber());
    // }
    
}