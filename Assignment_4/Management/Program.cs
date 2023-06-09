
namespace arrayManager
{
    public class ArrayManager<T>
    {

        public static T[] CreateArray()
        {
            Console.WriteLine("Enter the length of the array");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            T[] array = new T[arrayLength];

            for (int i = 0; i < arrayLength; i++)
            {
                Console.WriteLine("enter the element number " + i);
                
                array[i] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            }

            return array;
        }

        public static int[] SortArray(int[] intArray)
        {

            while (true)
            {
                bool isSorted = true;

                for (int i = 0; i < intArray.Length - 1; i++)
                {
                    if (intArray[i] > intArray[i + 1])
                    {
                        int temp = intArray[i];
                        intArray[i] = intArray[i + 1];
                        intArray[i + 1] = temp;
                        isSorted = false;
                    }
                }

                if (isSorted) { break; }
            }

            return intArray;

        }

        public static void WriteArray(T[] array)
        {
            foreach (T item in array)
                Console.Write(item + " ");
        }

    }

}

