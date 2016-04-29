using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

namespace NUnitConsole.Tests
{
    [TestFixture]
    public class CalculatorTest
    {
        [Test]
        public void MultiplyTest()
        {
            var calc = new Calculator();
            int result = calc.Multiply( 9, 3 );
            Assert.AreEqual( result, 27 );
        }

        [Test]
        public void MultiplyTestNotEqual()
        {
            var calc = new Calculator();
            int result = calc.Multiply(9, 5);
            Assert.AreNotEqual(result, 27);
        }
    }
}
