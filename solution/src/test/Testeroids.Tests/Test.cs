﻿namespace Testeroids.Tests
{
    using System.Threading.Tasks;

    public class Test
    {
        #region Fields

        private readonly ICalculator calculator;

        #endregion

        #region Constructors and Destructors

        public Test(ICalculator calculator)
        {
            this.calculator = calculator;
        }

        #endregion

        #region Public Properties

        public ICalculator Calculator
        {
            get
            {
                return this.calculator;
            }
        }

        #endregion

        #region Public Methods and Operators

        public void Clear()
        {
            this.Calculator.Clear();
        }

        public int Sum(int a,
                       int b)
        {
            return this.Calculator.Sum(a, b);
        }

        public Task<int> SumAsync(int a,
                                  int b)
        {
            return this.Calculator.SumAsync(a, b);
        }

        #endregion
    }
}