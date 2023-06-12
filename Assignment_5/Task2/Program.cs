using System.Collections.Concurrent;

static char[] CreateArray()
{
    Console.WriteLine("Input array length");

    int arrayLength = Convert.ToInt32(Console.ReadLine());

    char[] array = new char[arrayLength];

    for (int i = 0; i < arrayLength; i++)
    {
        Console.WriteLine("input element number " + i);
        array[i] = Convert.ToChar(Console.ReadLine());
    }

    return array;
}

static int CountElementInArray(char[] array, char symbol)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++) 
    {
        if (array[i] == symbol) count++;
    }
    return count;
}

static void OutputResult(char symbol, int count)
{
    Console.WriteLine(symbol+" was fount in the array "+count+" times");
}


char[] inputArray = CreateArray();

Console.WriteLine("Which element do you want to count in this array?");

char elementToCount = Convert.ToChar(Console.ReadLine());

OutputResult(elementToCount, CountElementInArray(inputArray, elementToCount));



