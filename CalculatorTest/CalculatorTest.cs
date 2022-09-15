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

        [TestCase(4, 4, 256)]
        [TestCase(4, 0, 1)]
        public void SubtractPowerReturnsTheSum(double x, double exp, double result)
        {
         
            double sum = Calculator.Power(x, exp);

            Assert.That(sum, Is.EqualTo(result).Within(0.1));

        }

    }
}