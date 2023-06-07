
Console.WriteLine("Enter numbers and to finish entering type \"finish\"");

List<decimal> Numbers = new List<decimal>();

while(true)
{
    var Input = Console.ReadLine();

    if (Input == "finish")
        break;
    else
        Numbers.Add(Convert.ToDecimal(Input));
}

decimal Sum = 0;
int NumberCount = 0;

foreach (var number in Numbers)
{
    if (number >0)
    { 
        Sum += number; 
        NumberCount++;
    }
}

decimal Average = Sum / NumberCount;

Console.WriteLine("The sum of the positive numbers is "+ Sum);
Console.WriteLine("The average of the positive numbers is "+ Average);
