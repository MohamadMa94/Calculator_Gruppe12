

namespace Calculator
{
    public class Calculator1
    {
        public double Add(double a, double b)
        {
            return a + b;
        }

        public double Subtract(double a, double b)
        {
            return a - b;
        }

        public double Multiply(double a, double b)
        {
            return a * b;
        }

        public double Power(double x, double exp)
        {
            double result;
            result = Math.Pow(x, exp);

            return result;
        }

        public double Divide(double dividend, double divisor)
        {
            double result;
            if (divisor == 0)
            {
                return 0;
                //throw new Exception();
            }

            result = dividend / divisor;

            return result;
        }

    }
}