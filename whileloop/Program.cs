bool locked = true;
int passCode = 13579;
while (locked)
{
    Console.WriteLine("Please enter passcode.");
    var passCodeEntry = int.Parse(Console.ReadLine());
    locked = !(passCode == passCodeEntry);
    if (locked)
    {
        Console.WriteLine("Incorrect passcode.");
    }
}
Console.WriteLine("Welcome in!");