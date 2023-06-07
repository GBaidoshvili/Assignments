
var InputNumber = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i<InputNumber;i++)
{
    for (int k = 0; k < InputNumber-i; k++)
    {
        Console.Write(" ");
    }

    for (int j = 0; j < 2*i+1; j++)
    {
        Console.Write("*");
    }
    Console.WriteLine();
}