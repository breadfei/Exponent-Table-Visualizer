Console.WriteLine("Welcome to the Exponent Table Visualizer!");

//setting initial variables
bool runLoop = true;
int num = 0;
do
{
    //getting user input
    Console.WriteLine("Please enter a positive integer.");
    num = int.Parse(Console.ReadLine());
    //validating
    while (num <= 0)
    {
        Console.WriteLine("Invalid number. Please try again.");
        num = int.Parse(Console.ReadLine());
    }

    //displaying tables
    Console.WriteLine("- 1 -\t- 2 -\t - 3 -");
    for (int i = 1; i <= num; i++)
    {
        int squared = i*i;
        int cubed = i * i * i;
        Console.WriteLine($"  {i}  \t  {squared}  \t  {cubed}");
    }

    //continue prompt
    Console.WriteLine("\nWould you like to continue? y/n");
    string answer = "";
    do
    {
        answer = Console.ReadLine();
        if (answer == "y")
        {
            break;
        }
        else if (answer == "n")
        {
            runLoop = false;
        }
        else
        {
            Console.WriteLine("Invalid input.");
        }
    } while (answer != "n");
} while (runLoop);

Console.WriteLine("Thank you for using the Exponent Table Visualizer.");