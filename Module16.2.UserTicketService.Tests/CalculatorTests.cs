#region screencast
//using Xunit;

//namespace Module16._2.UserTicketService.Tests
//{
//    public class CalculatorTests
//    {
//        [Fact]
//        public void MultiplicatorMustReturnNotNullValue()
//        {
//            var calculator = new Calculator();

//            Assert.Equal(8, calculator.Multiplication(2, 4));
//        }
//    }
//}
#endregion
#region 16.2.4 - 16.2.6
//using NUnit.Framework;

//namespace Module16._2.UserTicketService.Tests
//{
//    [TestFixture]
//    public class CalculatorTests
//    {
//        // Задание 16.2.4
//        [Test]
//        public void SubtractionMustReturnCorrectValue()
//        {
//            var calculator = new Calculator();

//            Assert.That(calculator.Subtraction(10, 5) == 5);
//        }

//        // Задание 16.2.5
//        [Test]
//        public void DivisionMustReturnCorrectValue()
//        {
//            var calculator = new Calculator();

//            Assert.That(calculator.Division(10, 5) == 2);
//        }

//        // Задание 16.2.6
//        [Test]
//        public void DivisionMustThrowException()
//        {
//            var calculator = new Calculator();

//            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
//        }
//    }
//}
#endregion
#region 16.2.7 - 16.2.9
//using Xunit;

//namespace Module16._2.UserTicketService.Tests
//{
//    public class CalculatorTests
//    {
//        // Задание 16.2.7
//        [Fact]
//        public void SubtractionMustReturnCorrectValue()
//        {
//            var calculator = new Calculator();

//            Assert.True(calculator.Subtraction(8, 3) == 5);
//        }

//        // Задание 16.2.8
//        [Fact]
//        public void DivisionMustReturnCorrectValue()
//        {
//            var calculator = new Calculator();

//            Assert.True(calculator.Division(8, 4) == 2);
//        }

//        // Задание 16.2.9
//        [Fact]
//        public void DivisionMustThrowException()
//        {
//            var calculator = new Calculator();

//            Assert.Throws<DivideByZeroException>(() => calculator.Division(30, 0));
//        }
//    }
//}
#endregion
#region 16.3
using NUnit.Framework;

namespace Module16._2.UserTicketService.Tests
{
    [TestFixture]
    public class CalculatorTests
    {
        [Test]
        public void AddAlwaysReturnsExpectedValue()
        {
            var calculatorTest = new Calculator();
            Assert.That(calculatorTest.Add(10, 220), Is.EqualTo(230));
        }
    }
}
#endregion