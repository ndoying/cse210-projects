using System;

class Program
{
    static void Main(string[] args)
    {
       Assignment assign1 = new Assignment("Mary Waters", "Algebra");
       
        string _summary = assign1.GetSummary();
        Console.WriteLine(_summary);

        MathAssignment math = new MathAssignment("Roberto Rodriquez", "Fractions", "7.3", "8-19");

        string _summary2 = math.GetSummary();
        string _homeworkList = math.GetHomeworkList();

        Console.WriteLine(_summary2);
        Console.WriteLine(_homeworkList);

        WritingAssignment essay = new WritingAssignment("The Causes of WWII", "Mary Waters", "European History");

        string _summary3 = essay.GetSummary();
        string _essayAssignment = essay.GetWritingInfo();

        Console.WriteLine(_summary3);
        Console.WriteLine(_essayAssignment);

    }
}