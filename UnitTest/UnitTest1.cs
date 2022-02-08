using Microsoft.VisualStudio.TestTools.UnitTesting;
using testWork.Libs;


namespace UnitTest
{


    [TestClass]
    public class FindUniqueTest
    {
        [TestMethod]
        public void TestUniqueWithSort1()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 7, 5, 4, 10, 1, 10 };
            int[] expected = new int[] { 2, 3, 5, 7 };

            int[] actual = Numbers.FindUniqueWithSort(arr);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUniqueWithSort2()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 7, 5, 4, 10, 1, 10, 2 };
            int[] expected = new int[] { 3, 5, 7 };

            int[] actual = Numbers.FindUniqueWithSort(arr);

            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestUnique1()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 7, 5, 4, 10, 1, 10 };
            int[] expected = new int[] { 2, 3, 7, 5 };

            int[] actual = Numbers.FindUnique(arr);

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestUnique2()
        {
            int[] arr = new int[] { 1, 2, 3, 4, 7, 5, 4, 10, 1, 10, 2 };
            int[] expected = new int[] { 3, 7, 5 };

            int[] actual = Numbers.FindUnique(arr);

            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestUniqueFloat1()
        {
            float[] arr = new float[] { 1.2f, 1.2f, 1.0009f, 1.0008f, 0.12f, 0.12f, 0.100001f, 0.100002f };
            float[] expected = new float[] { 1.0009f, 1.0008f, 0.100001f, 0.100002f };

            float[] actual = Numbers.FindUnique(arr);

            CollectionAssert.AreEqual(expected, actual);

        }

        [TestMethod]
        public void TestUniqueFloat2()
        {
            float[] arr = new float[] { 1.2f, 1.2f, 1.0009f, 1.0008f, 0.12f, 0.12f, 0.100001f, 0.100002f };
            float[] expected = new float[] { 1.0009f, 1.0008f };

            float[] actual = Numbers.FindUnique(arr, 0.0001f);

            CollectionAssert.AreEqual(expected, actual);

        }

    }
}
