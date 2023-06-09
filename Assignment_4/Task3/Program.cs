using arrayManager;

int[] firstArray = ArrayManager<int>.CreateArray();

int[] secondArray = ArrayManager<int>.CreateArray();

int[] mergedArray = firstArray.Concat(secondArray).ToArray();

mergedArray = ArrayManager<int>.SortArray(mergedArray);

ArrayManager<int>.WriteArray(mergedArray);





