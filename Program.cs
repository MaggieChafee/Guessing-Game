string greeting = @"    **** Welcome to Guess that Number! ****
Can you guess the secret number?
";

string guessPrompt = "What do you think the secret number is?";
int secretNumber = 42;
int maximumGuesses = 4;

Console.WriteLine(greeting);
Console.WriteLine(guessPrompt);
int userInput = 0;

for (int i = 0; i < maximumGuesses; i++)
{
    try
    {
        userInput = Convert.ToInt32(Console.ReadLine());
        if (userInput == secretNumber)
        {
            Console.WriteLine($"Guess number {i +1}: Congratulations! You guessed the secret number.");
            break;
        }
        else if (userInput != secretNumber)
        {
            Console.WriteLine($"Guess number {i + 1}: Looks like you didn't guess the secret number. Try again!");
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
Console.WriteLine("GAME OVER");



