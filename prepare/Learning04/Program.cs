using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment a1 = new Assignment("Luke Skywalker", "Multiplication");
        Console.WriteLine(a1.GetSummary());

        MathAssignment a2 = new MathAssignment("Harry Potter", "Fractions", "7.3", "42-45");
        Console.WriteLine(a2.GetSummary());
        Console.WriteLine(a2.GetHomeworkList());

        WritingAssignment a3 = new WritingAssignment("Pat Mahomes", "Super Bowl History", "Super Bowl LVII MVP");
        Console.WriteLine(a3.GetSummary());
        Console.WriteLine(a3.GetWritingInformation());
    }
}