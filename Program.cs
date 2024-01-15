string greeting = @"    **** Welcome to Guess that Number! ****
Can you guess the secret number?
";

string guessPrompt = "What do you think the secret number is?";

Console.WriteLine(greeting);
Console.WriteLine(guessPrompt);
string userInput = Console.ReadLine();
Console.WriteLine(userInput);