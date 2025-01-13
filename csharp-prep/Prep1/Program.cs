using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What's your first name? ");
        string FirstName = Console.ReadLine();
        Console.WriteLine("and what is your last name? ");
        string LastName = Console.ReadLine();
        Console.WriteLine($"Ah so your name is {LastName},{FirstName} {LastName}");
    }
}