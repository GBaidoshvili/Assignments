
using arrayManager;

int[] intArray = ArrayManager<int>.CreateArray();

List<int> longestSequence = new List<int>();
List<int> tempSequence = new List<int>();

tempSequence.Add(intArray[0]);

for (int i = 1; i < intArray.Length; i++)
{

    if (intArray[i] <= intArray[i-1])
    {
        if(tempSequence.Count > longestSequence.Count)
        {
            longestSequence.Clear();
            longestSequence.AddRange(tempSequence);
        }

        tempSequence.Clear();
    }

    tempSequence.Add(intArray[i]);
}


Console.WriteLine("The longest sequence is:");
foreach (int i in longestSequence)
    Console.Write(i);
