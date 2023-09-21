using System;

class Program
{
    static void Main(string[] args)
    {
    
        // Create a list of numbers from user input
    
        List<int> numbers = new List<int>();
        
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int number = -1;
        while (number != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            number = int.Parse(Console.ReadLine());
            if (number != 0)
            {
                numbers.Add(number);
            }
        
        }
        // Iterate through the numbers to sum, average and determine the largest number in the list.
        
        int sum = 0;
        int largest = 0;
        foreach (int i in numbers)
        {
            sum = sum + i;
            if (i > largest)
            {
                largest = i;
            }
        }
        Console.WriteLine($"The sum is: {sum}");
        int count = (numbers.Count);
        float average = ((float)sum) / count;
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {largest}");
    }
}