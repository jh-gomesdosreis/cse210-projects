using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your grade percentage?");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string gradeLetter = "";

        if (grade >= 90)
        {
            gradeLetter = "A";
        }
        else if (grade >= 80)
        {
            gradeLetter = "B";
        }
        else if (grade >= 70)
        {
            gradeLetter = "C";
        }
        else if (grade >= 60)
        {
            gradeLetter = "D";
        }
        else if (grade >= 50)
        {
            gradeLetter = "F";
        }

        Console.WriteLine($"Your grade is {gradeLetter}.");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        if (grade < 70)
        {
            Console.WriteLine("Better luck next time!");
        }
    }
}