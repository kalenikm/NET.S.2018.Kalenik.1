using System;

namespace Logic
{
    public static class ArraySorter
    {
        public static void QuickSort(int[] array)
        {
            if(array == null)
                throw new ArgumentNullException($"Array {nameof(array)} is null.");

            if(array.Length <= 1)
                return;

            QuickSort(array, 0, array.Length - 1);
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (right - left < 1)
                return;

            int pivot = right;
            int wall = left;

            for (int i = left; i < pivot; i++)
            {
                if (array[pivot] > array[i])
                {
                    Swap(ref array[i], ref array[wall]);
                    wall++;
                }
            }
            Swap(ref array[pivot], ref array[wall]);

            if (wall + 1 < right)
                QuickSort(array, wall + 1, right);
            if (wall - 1 > left)
                QuickSort(array, left, wall - 1);
        }

        private static void Swap(ref int a, ref int b)
        {
            int buff = a;
            a = b;
            b = buff;
        }
    }
}
