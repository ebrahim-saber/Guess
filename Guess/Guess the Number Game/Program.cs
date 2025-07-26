

// Step 1: Generate a random number between 1 and 100 

Random  random = new Random();
int randomNumber = random.Next(1, 101);

int userGuess = 0;
int attempts = 0;

Console.WriteLine("Welcome to the 'Guess the Number' game!");
Console.WriteLine("I have selected a number between 1 and 100. Try to guess it!");

// Step 2: Use a loop to keep asking the user for a guess until they get it right

while (userGuess != randomNumber)
{
    attempts++;

    // Step 3: Ask for the user's input
    Console.Write("Enter your guess: ");
    string input = Console.ReadLine();

    // Step 4: Validate user input
    //It wiil convert input from string to int and wiil save it at userGuess  
    if (!int.TryParse(input , out userGuess))
    {
        Console.WriteLine("Please enter a valid number.");
        continue;
    }

    // Step 5: Provide feedback on the guess
    if (userGuess < randomNumber)
    {
        Console.WriteLine("Too low! Try again.");
    }
    else if (userGuess > randomNumber)
    {
        Console.WriteLine("Too high! Try again.");
    }

}

// Step 6: When the user guesses correctly, congratulate them and display the number of attempts
Console.WriteLine($"Congratulations! You guessed the number {randomNumber} in {attempts} attempts.");