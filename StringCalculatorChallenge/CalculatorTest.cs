using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringCalculatorChallenge
{
    [TestFixture]
    public class CalculatorTest
    {
        [TestCase("20", 20)]
        [TestCase("1,5000", 5001)]
        [TestCase("4,-3", 1)]
        [TestCase("", 0)]
        [TestCase("5,tytyt", 5)]
        [TestCase("1\n2,3", 6)]
        public void AddNumberTest(string num, int expectedValue)
        {
            Assert.AreEqual(expectedValue, Calculator.AddNumber(num));
        }

    }
}