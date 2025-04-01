using System;

class BubbleSortProcedural
{
    static void BubbleSort(int[] array)
    {
        int n = array.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (array[j] > array[j + 1])
                {
                    int temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }

    static void PrintArray(int[] array)
    {
        foreach (int item in array)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] numbers = { 46, 14, 27, 9, 18, 19, 95 };

        Console.WriteLine("Original array:");
        PrintArray(numbers);

        // Sorting
        BubbleSort(numbers);

        Console.WriteLine("Sorted array:");
        PrintArray(numbers);
    }
}
