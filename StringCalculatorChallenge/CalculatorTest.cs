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
        [TestCase("1,2,3,4,5,6,7,8,9,10,11,12", 78)]
        public void AddNumberTest(string num, int expectedValue)
        {
            Assert.AreEqual(expectedValue, Calculator.AddNumber(num));
        }

    }
}