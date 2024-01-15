string greeting = @"    **** Welcome to Guess that Number! ****
Can you guess the secret number?
";

string guessPrompt = "What do you think the secret number is?";
int secretNumber = 42;

Console.WriteLine(greeting);
Console.WriteLine(guessPrompt);
string userInput = null;
while (userInput == null)
{
    try
    {
        int intUserInput = Convert.ToInt32(Console.ReadLine());
        if (intUserInput == secretNumber)
        {
            Console.WriteLine("Congratulations! You guessed the secret number.");
        }
        else if (intUserInput != secretNumber)
        {
            Console.WriteLine("Looks like you didn't guess the secret number. Better luck next time!");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine("Please type only integars!");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
        Console.WriteLine("Try again.");
    }
}
Console.WriteLine("Goodbye.");



