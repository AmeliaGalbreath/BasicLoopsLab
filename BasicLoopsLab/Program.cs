bool quitGame = false;
do
{
    Console.WriteLine("Hello, world!");
    Console.WriteLine("Would you like to continue (y/n)?");
    string answer = Console.ReadLine().Trim().ToLower();
    switch (answer)
    {
        case "n":
        case "no":
        case "nope":
            quitGame = true;
            break;
    }
}
while (quitGame == false);