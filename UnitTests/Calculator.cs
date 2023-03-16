using Calculator;
using NUnit.Framework;

namespace UnitTests
{
    public class Calculator
    {
        [TestCase(5, 5, ExpectedResult = 25)]
        [TestCase(7, 7, ExpectedResult = 49)]
        [TestCase(0, 0, ExpectedResult = 0)]
        [TestCase(-1, 1, ExpectedResult = -1)]
        [TestCase(-1, -1, ExpectedResult = 1)]
        public int Product(int actualInput1, int actualInput2)
        {
            return Program.Sandauga(actualInput1, actualInput2);
        }
    }
}
