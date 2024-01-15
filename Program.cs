string greeting = @"    **** Welcome to Guess that Number! ****
Can you guess the secret number?
";

string guessPrompt = "What do you think the secret number is?";
Random secretNumber = new Random();
int intSecretNumber = secretNumber.Next(1, 101);
int maximumGuesses = 4;

Console.WriteLine(greeting);
Console.WriteLine(guessPrompt);
int userInput = 0;

for (int i = 0; i < maximumGuesses; i++)
{
    try
    {
        userInput = Convert.ToInt32(Console.ReadLine());
        if (userInput == intSecretNumber)
        {
            Console.WriteLine($"Guess {i +1}: Congratulations! You guessed the secret number.");
            break;
        }
        else if (userInput != intSecretNumber)
        {
            Console.WriteLine($@"Guess {i + 1}: 
Looks like you didn't guess the secret number. You have {4 - (i+1)} guesses left.");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine($"Guess {i + 1}: Invalid input. You have {4 - (i + 1)} guesses left.");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
        Console.WriteLine("Try again.");
    }
}
Console.WriteLine("GAME OVER");



