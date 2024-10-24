using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1627;
using Xunit;

namespace Task1627Test
{
    public class CalculatorTest
    {
        [Fact]
        public void Subtraction_MustReturnCorrectValue()
        {
            var calc = new Calculator();
            Assert.Equal(3,calc.Subtraction(5, 2));
        }
    }
}
