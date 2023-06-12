static long SumDigits(long inputNumber)
{
    long sum = 0, digit = 0;

    while (inputNumber > 0)
    {
        digit = inputNumber % 10;
        sum = sum + digit;
        inputNumber = inputNumber / 10;
    }

    return sum;
}


static long ArrayElementDigitSum(int[] inputArray, int inputInt)
{
    return SumDigits(inputArray[inputInt]);
}


Console.WriteLine(ArrayElementDigitSum(new int[] {1561, 84949, 894984, 151891, 84998, 168841}, 5));
