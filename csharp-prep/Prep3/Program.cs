using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,10);
        
         int guess = -1;
        while (guess != number)
        {
            Console.WriteLine("What is the magic number? 1-10 ");
            guess = int.Parse(Console.ReadLine());
            if (guess > number)
            {
             Console.WriteLine("that's too high! try again");
            }
            else if (guess < number)
            {
                Console.WriteLine("that's too low! try again");
            }
            else if (guess == number)
            {
            Console.WriteLine("That's it!");
            }
            else 
            {
            Console.WriteLine("that's not a valid guess");
            }
        }
    }
}