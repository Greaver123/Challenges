using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges.Strings;
namespace Challenges.Tests.Strings
{
    [TestClass]
    public class WordEndingCounterTests
    {
        private WordEndingCounter counter;
        public WordEndingCounterTests()
        {
            counter = new WordEndingCounter();
        }

        [TestMethod]
        public void CounterCountWordsWithEnding_EndingY_One()
        {

            string text = "Ala ma koty";
            string endingLetter = "y";

            int expectedCount = 1;
            int actualResult = counter.CountWordsWithEnding(text, endingLetter);

            Assert.AreEqual(expectedCount, actualResult);

        }

        [TestMethod]
        public void CounterCountWordsWithEnding_TwoEndingY_Two()
        {

            string text = "Alay ma koty";
            string endingLetter = "y";

            int expectedCount = 2;
            int actualResult = counter.CountWordsWithEnding(text, endingLetter);

            Assert.AreEqual(expectedCount, actualResult);

        }

        [TestMethod]
        public void CounterCountWordsWithEnding_ThreeEndingY_Three()
        {

            string text = "Alay may koty";
            string endingLetter = "y";

            int expectedCount = 3;
            int actualResult = counter.CountWordsWithEnding(text, endingLetter);

            Assert.AreEqual(expectedCount, actualResult);

        }

        [TestMethod]
        public void CounterCountWordsWithEnding_EmptyText_Zero()
        {

            string text = "";
            string endingLetters = "y";
            int expectedCount = 0;
            int actualResult = counter.CountWordsWithEnding(text, endingLetters);

            Assert.AreEqual(expectedCount, actualResult);

        }

        [TestMethod]
        public void CounterCountWordsWithEnding_EmptyTextAndEndings_Zero()
        {
            string text = "";
            string endingLetters = "";
            int expectedCount = 0;
            int actualResult = counter.CountWordsWithEnding(text, endingLetters);

            Assert.AreEqual(expectedCount, actualResult);
        }

        [TestMethod]
        public void CounterCountWordsWithEnding_TextwithYZEndings_Two()
        {
            string text = "Ala ma koty i psyz";
            string endingLetters = "yz";
            int expectedCount = 2;
            int actualResult = counter.CountWordsWithEnding(text, endingLetters);

            Assert.AreEqual(expectedCount, actualResult);
        }

        [TestMethod]
        public void CounterCountWordsWithEnding_OnlyWhitspacetextAndTwoEndings_Zero()
        {
            string text = "               ";
            string endingLetters = "YZ";
            int expectedCount = 0;
            int actualResult = counter.CountWordsWithEnding(text, endingLetters);

            Assert.AreEqual(expectedCount, actualResult);
        }

        [TestMethod]
        public void CounterCountWordsWithEnding_OnlyWhitspacesWithOneWordWithEndingY_One()
        {
            string text = "  kotyz    ";
            string endingLetters = "YZ";
            int expectedCount = 1;
            int actualResult = counter.CountWordsWithEnding(text, endingLetters);

            Assert.AreEqual(expectedCount, actualResult);
        }


    }
}
