using System;

namespace Logic
{
    public static class ArraySorter
    {
        /// <summary>
        /// Sorts int array by Hoar's alghorithm. 
        /// </summary>
        /// <param name="array">
        /// Array to sort.
        /// </param>
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

        /// <summary>
        /// Sorts int array by merge alghorithm.
        /// </summary>
        /// <param name="array">
        /// Array to sort.
        /// </param>
        public static void MergeSort(int[] array)
        {
            if (array == null)
                throw new ArgumentNullException($"Array {nameof(array)} is null.");

            if (array.Length == 1)
                return;

            int mid = array.Length / 2;

            int[] right = new int[array.Length - mid];
            int[] left = new int[mid];

            Array.Copy(array, 0, left, 0, mid);
            Array.Copy(array, mid, right, 0, array.Length - mid);

            MergeSort(left);
            MergeSort(right);

            int[] res = Merge(left, right);

            res.CopyTo(array, 0);
        }

        private static int[] Merge(int[] left, int[] right)
        {
            int len = left.Length + right.Length;
            int[] result = new int[len];
            int l = 0;
            int r = 0;

            for (int i = 0; i < len; i++)
            {
                if (r >= right.Length)
                {
                    result[i] = left[l];
                    l++;
                }
                else if (l < left.Length && left[l] < right[r])
                {
                    result[i] = left[l];
                    l++;
                }
                else
                {
                    result[i] = right[r];
                    r++;
                }
            }
            return result;
        }
    }
}
