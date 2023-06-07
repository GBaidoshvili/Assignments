


while(true)
{
    Console.WriteLine("Input min number:");

    int Min = Convert.ToInt32(Console.ReadLine());


    Console.WriteLine("Input max number:");

    int Max = Convert.ToInt32(Console.ReadLine());

    Random rnd = new Random();

    int RandomNumber = rnd.Next(Min, Max);

    Console.WriteLine("Guess the number");

    while (true)
    {
        int Guess = Convert.ToInt32(Console.ReadLine());
        if (Guess == RandomNumber)
        {
            Console.WriteLine("You guessed the number");
            break;
        }
        else
        {
            Console.WriteLine("Try again");
        }
    }

    Console.WriteLine("Do you want to try again (Type yes/no)");

    

    while (true)
    {
        var Answer = Console.ReadLine();

        if (Answer == "yes")
        {
            Console.WriteLine("Here we go again");
            break;
        }
        else if (Answer == "no")
        {
            Console.WriteLine("Bye");
            Environment.Exit(0);
        }
        else
        {
            Console.WriteLine("ha?");
        }
    }

}

