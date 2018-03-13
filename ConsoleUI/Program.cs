using System;
using Logic;

namespace ConsoleUI
{
    class Program
    {
        static void Main()
        {
            int[] arr = {3, 0, 1, 8, 7, 2, 5, 4, 9, 6};
            ArraySorter.QuickSort(arr);

            foreach (var num in arr)
                Console.Write(num + " ");
        }
    }
}
