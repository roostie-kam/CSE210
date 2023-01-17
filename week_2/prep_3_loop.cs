 	using System;

class Program
{
    static void Main(string[] args)
    {
        // For Parts 1 and 2, where the user specifies the number...
        // Console.Write('What is the magic number? ');
        // int magicNumber = int.Parse(Console.ReadLine());
        
        // For Part 3, where we use a random number
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 100);

        int guess = -1;

        // We can also use a do-while loop here...
        while (guess != magicNumber)
        {
            Console.Write("Dude! Please guess, a really low number....");
            guess = int.Parse(Console.ReadLine());

            if (magicNumber < guess)
            {
                Console.WriteLine("Lower");
            }
            else if (magicNumber > guess)
            {
                Console.WriteLine("Dude! Please guess, a really high number....");
            }
            else if (magicNumber < guess)
            {
                Console.WriteLine("Higher");
            }
            else
            {
                Console.WriteLine("Dude! You got it right that's for dang sure!");
            }

        }                    
    }
}