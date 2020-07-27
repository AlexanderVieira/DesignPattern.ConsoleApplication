using System;

namespace AVS.DesignPatterns.Behavioral.Command
{
    public class Calculator
    {
        private int _currentValue;

        public void Operation(char mOperator, int value)
        {
            switch (mOperator)
            {
                case '+':
                    _currentValue += value;
                    break;
                case '-':
                    _currentValue -= value;
                    break;
                case '*':
                    _currentValue *= value;
                    break;
                case '/':
                    _currentValue /= value;
                    break;                
            }
            Console.WriteLine("(dado {1} {2}) - Current value = {0,3}", _currentValue, mOperator, value);
        }
    }
}
