using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Prep3 World!");
    
        // Console.Write("What is the Magic Number? ");
        // int number = int.Parse(Console.ReadLine());
        
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(0,101);
        Console.Write("What is your guess? ");
        int guess = int.Parse(Console.ReadLine());
        
        while (number != guess)
        {
            if (number > guess)
            {
                Console.WriteLine("Higher");
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }
            else if (number < guess)
            {
                Console.WriteLine("Lower");
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
            }
        }
        
        Console.WriteLine("You guessed it!");
        

    }
}