using System;

namespace AVS.DesignPatterns.Behavioral.Command
{
    public class CalculatorCommand : Commander
    {
        private char _operator;
        private int _value;
        private readonly Calculator _calculator;

        public CalculatorCommand(char mOperator, int value, Calculator calculator)
        {
            _operator = mOperator;
            _value = value;
            _calculator = calculator;
        }

        public char Operator { set => _operator = value; }

        public int Operando { set => _value = value; }

        public override void Run()
        {
            _calculator.Operation(_operator, _value);
        }

        public override void UnMake()
        {
            _calculator.Operation(UnManke(_operator), _value);
        }

        private static char UnManke(char mOperator)
        {
            switch (mOperator)
            {
                case '+': return '-';
                case '-': return '+';
                case '*': return '/';
                case '/': return '*';
                default: throw new ArgumentException("Unknown operator");
            }
        }        
    }
}
