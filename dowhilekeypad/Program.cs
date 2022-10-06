int attempts = 1;
int passCode = 13579;
do
{
    Console.WriteLine("Please enter passcode.");

    var passCodeEntry = int.Parse(Console.ReadLine());

    if (passCode == passCodeEntry)
    {
        Console.WriteLine("Welcome in!");
        break;
    }
    Console.WriteLine("Incorrect passcode.");
    attempts++;
} while (attempts < 6);
Console.WriteLine("You have run out of retries.");