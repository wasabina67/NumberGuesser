// Number Guessing Game
// Constants for game configuration
const int MIN_NUMBER = 1;
const int MAX_NUMBER = 1000;

// Initialize random number generator
Random random = new Random();
int targetNumber = random.Next(MIN_NUMBER, MAX_NUMBER + 1);
int attempts = 0;
bool hasWon = false;

Console.WriteLine("Welcome to the Number Guessing Game!");
Console.WriteLine($"I'm thinking of a number between {MIN_NUMBER} and {MAX_NUMBER}.");
Console.WriteLine("Can you guess what it is?");
Console.WriteLine();

// Main game loop
while (!hasWon)
{
    Console.Write("Enter your guess: ");
    string? input = Console.ReadLine();

    // Validate input
    if (string.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("Please enter a valid number.");
        continue;
    }

    if (!int.TryParse(input, out int guess))
    {
        Console.WriteLine("Please enter a valid integer.");
        continue;
    }

    if (guess < MIN_NUMBER || guess > MAX_NUMBER)
    {
        Console.WriteLine($"Please enter a number between {MIN_NUMBER} and {MAX_NUMBER}.");
        continue;
    }

    attempts++;

    // Check the guess
    if (guess == targetNumber)
    {
        hasWon = true;
        Console.WriteLine();
        Console.WriteLine("// ===================================");
        Console.WriteLine("Congratulations! You guessed it!");
        Console.WriteLine($"The number was {targetNumber}.");
        Console.WriteLine($"It took you {attempts} attempt{(attempts == 1 ? "" : "s")}.");

        // Provide feedback based on performance
        if (attempts <= 5)
        {
            Console.WriteLine("Excellent! You're a natural at this!");
        }
        else if (attempts <= 10)
        {
            Console.WriteLine("Good job! That was well done!");
        }
        else if (attempts <= 15)
        {
            Console.WriteLine("Not bad! You got there in the end!");
        }
        else
        {
            Console.WriteLine("You made it! Practice makes perfect!");
        }
        Console.WriteLine("// ===================================");
    }
    else if (guess < targetNumber)
    {
        Console.WriteLine("Too low! Try a higher number.");
    }
    else
    {
        Console.WriteLine("Too high! Try a lower number.");
    }

    Console.WriteLine();
}

Console.WriteLine("Thanks for playing!");
