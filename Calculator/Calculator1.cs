

namespace Calculator
{
    public class Calculator1
    {
        private double _accumulator = 0;
        public double Accumulator
        {
            get { return _accumulator;}
            private set { _accumulator = value; }
        }

        public void Clear()
        {
            _accumulator = 0;
        }


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
            }

            result = dividend / divisor;

            return result;
        }



    }
}