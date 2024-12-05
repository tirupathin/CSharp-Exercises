// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Exercise - The Prototype
// int input = 0;
// Console.WriteLine("User 1, enter a number between 0 and 100: ");
// input = Convert.ToInt32(Console.ReadLine());
// while (input < 0 || input > 100)
// {
//     Console.WriteLine("User 1, Re-enter a number between 0 and 100: ");
//     input = Convert.ToInt32(Console.ReadLine());
//     if (input <= 0 || input > 100)
//     {
//         continue;
//     }
//     else
//     { break; }

// }


// Console.WriteLine("Number entered is " + input);
// Console.Clear();
// int guessInput = 0;
// Console.WriteLine("User 2, guess the number. ");


// while (true)
// {
//     Console.Write("What is your next guess? ");
//     guessInput = Convert.ToInt32(Console.ReadLine());



//     if (guessInput > input) Console.WriteLine($"{guessInput} is too high.");
//     else if (guessInput < input) Console.WriteLine($"{guessInput} is too low.");
//     else break;
// }
// Console.WriteLine("You guessed the number!");

// Exercise - The Magic Cannon
Console.WriteLine("Start of the Program...");
for (int i = 1; i < 120; i++)
{
    if ((i % 3 == 0) && (i % 5 == 0))
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"{i} : Electric and Fire");

    }
    else if (i % 3 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine($"{i} : Fire");
    }
    else if (i % 5 == 0)
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine($"{i} : Electric");
    }
    else
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine($"{i} : Normal");
    }
}