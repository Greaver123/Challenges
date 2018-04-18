using Microsoft.VisualStudio.TestTools.UnitTesting;
using Challenges.Miscellaneous;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challenges.Miscellaneous.Tests
{
    [TestClass()]
    public class NumberToStringFormatterTests
    {
        private NumberToStringFormatter formatter;

        public NumberToStringFormatterTests()
        {
            formatter = new NumberToStringFormatter();
        }
        [TestMethod()]
        public void FormatNumber_IntegerOne_StringOne()
        {
            int number = 1;
            var expected = "one";
            var actual = formatter.FormatNumber(number);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void FormatNumber_IntegerNinteen_StringNinteen()
        {
            int number = 19;
            var expected = "ninteen";
            var actual = formatter.FormatNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FormatNumber_IntegerTwenty_StringTwenty()
        {
            int number = 20;
            var expected = "twenty";
            var actual = formatter.FormatNumber(number);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FormatNumber_IntegerNinty_StringNinty()
        {
            int number = 90;
            var expected = "ninty";
            var actual = formatter.FormatNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FormatNumber_TwentyOne_StringTwnetyOne()
        {
            int number = 21;
            var expected = "twenty one";
            var actual = formatter.FormatNumber(number);

            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void FormatNumber_NintyNine_StringNintyNine()
        {
            int number = 99;
            var expected = "ninty nine";
            var actual = formatter.FormatNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void FormatNumber_FourtyFive_StringFourtyFive()
        {
            int number = 45;
            var expected = "fourty five";
            var actual = formatter.FormatNumber(number);

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FormatNumber_OneHundred_ThrowsArgumentException()
        {
            int number = 100;
            var actual = formatter.FormatNumber(number);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void FormatNumber_Zero_ThrowsArgumentException()
        {
            int number = 0;
            var actual = formatter.FormatNumber(number);
        }


    }
}