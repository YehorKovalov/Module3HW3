using System;

namespace DelegatePractice
{
    public class Class2
    {
        private double _calcPowResult;

        public Predicate<double> Calc(Func<double, double, double> operation, double x, double y)
        {
            if (operation != null)
            {
                _calcPowResult = operation.Invoke(x, y);
            }

            return Result;
        }

        private bool Result(double x) => _calcPowResult % x == 0;
    }
}
