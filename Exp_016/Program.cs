// Упорядочить массив
int[] arr = { 3, 2, 5, 1, 4, -1, 0 };
void PrintArray(int[] array)
{
    int count = array.Length;

    for (int y = 0; y < count; y++)
    {
        Console.Write($"{array[y]} ");
    }
    Console.WriteLine();
}
void SelectionSort(int[] array)
{
    for (int i = 0; i < array.Length - 1; i++)
    {
        int minPosition = i;
        for (int j = i + 1; j < array.Length; j++)
        {
            if (array[j] < array[minPosition])
            {
                minPosition = j;
            }
        }
        int temporary = array[i];
        array[i] = array[minPosition];
        array[minPosition] = temporary;
    }
}

PrintArray(arr);
SelectionSort(arr);
PrintArray(arr);