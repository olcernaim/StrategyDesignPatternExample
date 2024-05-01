using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathStrategy
{
    public class MathOperation
    {
        private Strategy _strategy;

        public MathOperation(Strategy strategy)
        {
            _strategy = strategy;
        }

        public int Execute(int num1, int num2)
        {
            return _strategy.doOperation(num1, num2);
        }
    }
}
