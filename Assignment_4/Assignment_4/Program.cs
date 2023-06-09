using arrayManager;


    int[] ints = ArrayManager<int>.CreateArray();

    Console.WriteLine("Sorting your array");

    ints = ArrayManager<int>.SortArray(ints);

    ArrayManager<int>.WriteArray(ints);

