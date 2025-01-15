using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your grade?");
        string response = Console.ReadLine();
        int grade = int.Parse(response);

        string letter = "";

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else 
        {
            letter = "f";
        }

        Console.WriteLine($"your grade is {letter} ");

        if (grade >= 70)
        {
            Console.WriteLine("you passed your class!");
        }
        else 
        {
            Console.WriteLine("welp");
        }
    }
}