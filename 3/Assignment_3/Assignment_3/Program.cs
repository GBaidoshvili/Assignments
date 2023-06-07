

var InputtString = Console.ReadLine();

if (InputtString == "")
{
    Console.WriteLine("Invalid input");
    return;
}

var InputInt = Convert.ToInt64(InputtString);

bool Result = false;

if (InputInt == 0 || InputInt == 1)
    Result = false;
else
{
    for (int i = 2; i <= Math.Sqrt(InputInt); i++)
    {
        if (InputInt % i == 0)
        {
            Result = false;
            break;
        }
        Result = true;
    }
}

var Output = "This number is" + (!Result ? " not" : "") + " prime";

Console.WriteLine(Output);

