string greeting = @"    **** Welcome to Guess that Number! ****
Can you guess the secret number?
";

string difficultyPrompt = @"Select your difficuly level:
    1. Easy (Total of 8 guesses)
    2. Medium (Total of 6 guesses)
    3. Hard (Total of 4 gueses)
    4. Cheater (As many guesses as you want)

Type the number of your preferred difficulty level.";
int difficultyChoice = 0;
string guessPrompt = "What do you think the secret number is?";
Random secretNumber = new Random();
int intSecretNumber = secretNumber.Next(1, 101);
int easyGuesses = 8;
int mediumGuesses = 6;
int hardGuesses = 4;
int cheaterGuesses = 100000;

Console.WriteLine(greeting);
Console.WriteLine(difficultyPrompt);

void Difficulty()
{
    while (difficultyChoice == 0)
    {
        try
        {
            difficultyChoice = Convert.ToInt32(Console.ReadLine());
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
}

Difficulty();
int maximumGuesses = 0;

if (difficultyChoice == 1)
{
    maximumGuesses = easyGuesses;
}
else if (difficultyChoice == 2)
{
    maximumGuesses = mediumGuesses;
}
else if (difficultyChoice == 3)
{
    maximumGuesses = hardGuesses;
} else if (difficultyChoice == 4)
{
    maximumGuesses = cheaterGuesses;
}

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
Your guess was too {(userInput > intSecretNumber ? "high" : "low")}. You have {(maximumGuesses == cheaterGuesses ? "infinite" : maximumGuesses - (i+1))} guesses left.");
        }
    }
    catch (FormatException)
    {
        Console.WriteLine($"Guess {i + 1}: Invalid input. You have {maximumGuesses - (i + 1)} guesses left.");
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.ToString());
        Console.WriteLine("Try again.");
    }
}
Console.WriteLine("GAME OVER");



