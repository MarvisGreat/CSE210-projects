using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = squareNumber(userNumber);

        DisplayResult(userName, squaredNumber);

        static void  DisplayWelcomeMessage()
        {
            Console.WriteLine("Welcome to the program");
        }

        static string PromptUserName()
        {
            Console.Write("What is your name? ");
            string name = Console.ReadLine();

            return name;
        }
        
        static int PromptUserNumber()
        {
            Console.Write("Please enter your favoritte numvber:");
            string number = Console.ReadLine();
            int numbers = int.Parse(number);

            return numbers;
        }

        static int squareNumber(int numbers)
        {
            int square = numbers * numbers;
            return square;
        }
        static void  DisplayResult(string name, int square)
        {
            Console.WriteLine($"{name}, the square of your number is {square}");
        }
    }
}