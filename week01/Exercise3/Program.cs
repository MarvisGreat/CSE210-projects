using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int numb = randomGenerator.Next(1, 100);

        int value = -1;
        int guesses = 0;

        while (value != numb)
        {    guesses++; 
            Console.WriteLine("What is your guess? ");
            string guess = Console.ReadLine();
            value = int.Parse(guess);

            string result = "";
            if (value > numb)
            {
                result = "Lower";
            }

            else if (value < numb)
            {
                result = "Higher";
            }
            else
            {
                result = "You guessed it right!";
            }

            Console.WriteLine(result);
            Console.WriteLine($"You made a total of {guesses} guesses.");
        }
    }
}