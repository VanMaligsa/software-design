using System;
using System.Collections.Generic;

class Sorter
{
    public void SortArray(List<int> arr)
    {
        arr.Sort((a, b) => b.CompareTo(a));
    }

    public void DisplayArray(List<int> arr)
    {
        Console.WriteLine(string.Join(" ", arr));
    }
}

class Program
{
    static void Main()
    {
        List<int> numbers = new List<int> { 15, 2, 41, 31, 5, 69 };

        Sorter sorter = new Sorter();
        Console.WriteLine("Original Array:");
        sorter.DisplayArray(numbers);

        sorter.SortArray(numbers);

        Console.WriteLine("Descending Order:");
        sorter.DisplayArray(numbers);
    }
}