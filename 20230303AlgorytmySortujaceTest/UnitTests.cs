using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace TestingSortingAlgorithms
{
    // Paulina Sikorska
    [TestClass]
    public class UnitTests
    {
        int[] tablica = { 73, 93, 151, 8, 166, 190, 164, 169, 185, 123, 12, 60, 13, 20, 64, 153, 15, 111, 187, 193, 79, 156, 14, 45, 168, 197, 133, 186, 103, 102, 71, 179, 163, 27, 199, 43, 159, 100, 26, 9, 75, 150, 29, 37, 181, 106, 72, 61, 57, 56 };
        int[] expected = { 8, 9, 12, 13, 14, 15, 20, 26, 27, 29, 37, 43, 45, 56, 57, 60, 61, 64, 71, 72, 73, 75, 79, 93, 100, 102, 103, 106, 111, 123, 133, 150, 151, 153, 156, 159, 163, 164, 166, 168, 169, 179, 181, 185, 186, 187, 190, 193, 197, 199 };
        int[] actual;
        [TestMethod]
        public void TestSelectionSort()
        {
            actual = SortingAlgorithms.SelectionSort(tablica);
            Assert.IsTrue(expected.SequenceEqual(actual));
        }
        [TestMethod]
        public void TestSelectionSort2()
        {
            actual = SortingAlgorithms.SelectionSort(tablica);
            CollectionAssert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void TestInsertionSort()
        {
            SortingAlgorithms.InsertionSort(tablica);
            CollectionAssert.AreEqual(tablica, expected);
        }
        [TestMethod]
        public void TestQuickSort()
        {
            SortingAlgorithms.QuickSort(tablica, 0,49);
            CollectionAssert.AreEqual(tablica, expected);
        }
    }
}
