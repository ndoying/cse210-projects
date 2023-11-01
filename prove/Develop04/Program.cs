using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        bool _continueRunning = true;

        Activities _theActivity = new Activities("Default Name", "Default Description");

        while (_continueRunning)
        {
            Console.WriteLine("\nMenu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu \n>>");

            int _userInput = int.Parse(Console.ReadLine());

            
            switch (_userInput)
            {
                case 1:
                    _theActivity.StartBreathingActivity();
                    break;
                case 2:
                    break;
                case 3:
                    break;
                case 4:
                    _continueRunning = false;
                    break;

            }
        }
    }
}