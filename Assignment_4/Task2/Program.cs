using arrayManager;


string[] firstArray = ArrayManager<string>.CreateArray();


int[] secondArray = ArrayManager<int>.CreateArray();



Console.WriteLine("Your mixed array is:");

for (int i = 0; i < Math.Max(firstArray.Length, secondArray.Length); i++)
{
    if (i < firstArray.Length)
        Console.Write(firstArray[i] + " ");
    if (i < secondArray.Length)
        Console.Write(secondArray[i] + " ");
}

