int passCode = 13579;
int attempts = 1;
string goodByeMessage = "You have run out of retries.";
while (attempts < 6)
{
    Console.WriteLine("Please enter passcode.");
    var passCodeEntry = int.Parse(Console.ReadLine());
    if (passCode == passCodeEntry)
    {
        goodByeMessage = "Welcome in!";

        break;
    }
    Console.WriteLine("Incorrect passcode.");
    attempts++;
}
Console.WriteLine(goodByeMessage);