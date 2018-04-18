using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges.Miscellaneous;
namespace Challenges.Tests.Miscellaneous
{
    /// <summary>
    /// Summary description for ArrayReverserTest
    /// </summary>
    [TestClass]
    public class ArrayReverserTest
    {
        private ArrayReverser<int> reverser;

        public ArrayReverserTest()
        {
            reverser = new ArrayReverser<int>();
        }

        [TestMethod]
        public void Reverse_ArrayWithOddNumberOfElements_ReversedListOfNumbers()
        {

            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            var expectedResult = new int[] { 7, 6, 5, 4, 3, 2, 1 };

            var actualResult = reverser.Reverse(numbers);

            CollectionAssert.AreEqual(expectedResult, actualResult);

        }
        [TestMethod]
        public void Reverse_ArrayWithEvenNumberOfElements_ReversedListOfNumbers()
        {

            var numbers = new int[] { 1, 2, 3, 4, 5, 6, };

            var expectedResult = new int[] { 6, 5, 4, 3, 2, 1 };

            var actualResult = reverser.Reverse(numbers);

            CollectionAssert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void Reverse_EmptyArray_ThrowsArgumentExpection()
        {
            var numbers = new int[] { };
            var actualResult = reverser.Reverse(numbers);
        }

        [TestMethod]
        public void Reverse_ArrayWithOneNumber_ArrayWithOneNumber()
        {
            var numbers = new int[] { 1 };

            var expectedResult = new int[] { 1 };

            var actualResult = reverser.Reverse(numbers);

            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        public void Reverse_ArrayWithTwoNumbers_ArrayWithTwoNumbers()
        {
            var numbers = new int[] { 1, 2 };

            var expectedResult = new int[] { 2, 1 };

            var actualResult = reverser.Reverse(numbers);

            CollectionAssert.AreEqual(expectedResult, actualResult);
        }

        [TestMethod]
        [TestCategory("builtIn")]
        public void ReverseBuiltIN_ArrayWithOddNumberOfElements_ReversedListOfNumbers()
        {

            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7 };

            var expectedResult = new int[] { 7, 6, 5, 4, 3, 2, 1 };

            var actualResult = reverser.ReverseBuiltIn(numbers);

            CollectionAssert.AreEqual(expectedResult, actualResult);

        }

        [TestMethod]
        [TestCategory("builtIn")]
        public void ReverseBuiltIn_ArrayWithEvenNumberOfElements_ReversedListOfNumbers()
        {

            var numbers = new int[] { 1, 2, 3, 4, 5, 6, };

            var expectedResult = new int[] { 6, 5, 4, 3, 2, 1 };

            var actualResult = reverser.ReverseBuiltIn(numbers);

            CollectionAssert.AreEqual(expectedResult, actualResult);

        }
    }
}

