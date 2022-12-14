using Calculator;

namespace CalculatorTest
{
    public class CalculatorTest
    {

        private Calculator1 Calculator;
        [SetUp]
        public void Setup()
        {
            Calculator  = new Calculator1();
        }

        [Test]
        public void Test1()
        {
            Assert.Pass();
        }

        [TestCase(4, 5, 9)]
        [TestCase(4, 3, 7)]
        [TestCase(4, 0, 4)]
         public void Add_ReturnsTheSum(double a, double b, double result)
        {
            

            double sum = Calculator.Add(a, b);
            Assert.That(sum, Is.EqualTo(result));

        }

        [TestCase(4, 4, 0)]
        [TestCase(9, 1, 8)]
        [TestCase(6, 4, 2)]
        public void Subtract_ReturnsTheSum(double a, double b, double result)
        {           

            double sum = Calculator.Subtract(a, b);

            Assert.That(sum, Is.EqualTo(result).Within(0.01));

        }
        [TestCase(4, 4, 16)]
        [TestCase(6, 4, 24)]
        [TestCase(36, 0, 0)]
        [TestCase(5, 5, 25)]
        public void Subtract_1ReturnsTheSum(double a, double b, double result)
        {
            
            double sum = Calculator.Multiply(a, b);
            Assert.That(sum, Is.EqualTo(result));

        }
        [TestCase(2, 3, 8)]
        [TestCase(4, 4, 256)]
        [TestCase(4, 0, 1)]
        public void SubtractPowerReturnsTheSum(double x, double exp, double result)
        {
         
            double sum = Calculator.Power(x, exp);

            Assert.That(sum, Is.EqualTo(result).Within(0.1));

        }

        [TestCase(2, 2, 1)]
        [TestCase(5, 0, 0)]
        [TestCase(33,3,11)]
        public void DivideReturnsTheSum(double dividend, double divisor, double result)
        {
            double sum = Calculator.Divide(dividend, divisor);

            Assert.That(sum, Is.EqualTo(result).Within((0.1)));
        }

        [TestCase(2,3, 5)]
        [TestCase(8,4 , 12)]
        [TestCase(9, 1, 10)]
        public void AccumulatorSetDuringAdd(double a, double b, double expected)
        {
            Calculator.Add(a, b);
            Assert.That(expected, Is.EqualTo(Calculator.Accumulator).Within(0.1));
        }

        [TestCase(2, 3, -1)]
        [TestCase(8, 4, 4)]
        [TestCase(9, 1, 8)]
        public void AccumulatorSetDuringSubtract(double a, double b, double expected)
        {
            Calculator.Subtract(a, b);
            Assert.That(expected, Is.EqualTo(Calculator.Accumulator).Within(0.1));
        }

        [TestCase(2, 3, 6)]
        [TestCase(8, 4, 32)]
        [TestCase(9, 1, 9)]
        public void AccumulatorSetDuringMultiply(double a, double b, double expected)
        {
            Calculator.Multiply(a, b);
            Assert.That(expected, Is.EqualTo(Calculator.Accumulator).Within(0.1));
        }

        [TestCase(2, 3, 8)]
        [TestCase(4, 4, 256)]
        [TestCase(4, 0, 1)]
        public void AccumulatorSetDuringPower(double a, double b, double expected)
        {
            Calculator.Power(a, b);
            Assert.That(expected, Is.EqualTo(Calculator.Accumulator).Within(0.1));
        }

        [TestCase(2, 2, 1)]
        [TestCase(5, 0, 0)]
        [TestCase(33, 3, 11)]
        public void AccumulatorSetDuringDivide(double a, double b, double expected)
        {
            Calculator.Divide(a, b);
            Assert.That(expected, Is.EqualTo(Calculator.Accumulator).Within(0.1));
        }

        [TestCase(2,4)]
        [TestCase(2587, 6)]
        [TestCase(25, 9)]
        public void ClearTest(double a, double b)
        {
            Calculator.Add(a,b);
            Calculator.Clear();

            Assert.That(0, Is.EqualTo(Calculator.Accumulator));
        }


        /*
        public void DivideThrowsException(double dividend, double divisor, double result)
        {
            double sum = Calculator.Divide(dividend, divisor);
            
             Assert.Throws<Exception>()
            {

            }
        }
        */

    }
}