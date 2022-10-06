bool reRun = true;
string userSelection = "";

while (reRun)
{
    Console.WriteLine("Please enter a number: ");
    int userEntry = int.Parse(Console.ReadLine());
    string increasingList = "";
    string decreasingList = "";
    for (int i = 0; i <= userEntry; i++)
    {
        increasingList = increasingList + $" {i}";
    }
    for (int i = userEntry; i >= 0; i--)
    {
        decreasingList = decreasingList + $" {i}";
    }
    Console.WriteLine(decreasingList.Trim());
    Console.WriteLine(increasingList.Trim() + "\n");
    Console.WriteLine("Would you like to continue? Press y to continue or any other key to quit:");
    userSelection = Console.ReadLine();
    reRun = userSelection.Trim().ToLower() == "y";
}

Console.WriteLine("Goodbye!");