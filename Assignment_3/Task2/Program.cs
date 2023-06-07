

var InputtString = Console.ReadLine();

if(InputtString == null)
{
    Console.WriteLine("Invalid input");
    return;
}

var InputInt = Convert.ToInt64((string)InputtString);

int DivisorCount = 0;

for (int i = 1; i <= Math.Sqrt(InputInt); i++)
{
    DivisorCount += (InputInt % i == 0)?((InputInt/i==i)?1:2):0;
}


var Output = "This number has " + DivisorCount + " divisors";

Console.WriteLine(Output);