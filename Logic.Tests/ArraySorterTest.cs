using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic;

namespace Logic.Tests
{
    [TestClass]
    public class ArraySorterTest
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void QuickSort_ThrowException()
        {
            ArraySorter.QuickSort(null);
        }

        [TestMethod]
        public void QuickSort_NormalSort()
        {
            int[] array = { 5, 2, 1, 4, 3 };
            int[] result = { 1, 2, 3, 4, 5 };

            ArraySorter.QuickSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(result[i], array[i]);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void MergeSort_ThrowException()
        {
            ArraySorter.QuickSort(null);
        }

        [TestMethod]
        public void MergeSort_NormalSort()
        {
            int[] array = { 5, 2, 1, 4, 3 };
            int[] result = { 1, 2, 3, 4, 5 };

            ArraySorter.MergeSort(array);

            for (int i = 0; i < array.Length; i++)
            {
                Assert.AreEqual(result[i], array[i]);
            }
        }
    }
}
