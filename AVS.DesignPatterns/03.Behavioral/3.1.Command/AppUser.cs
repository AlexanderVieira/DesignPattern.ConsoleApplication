using System;
using System.Collections.Generic;

namespace AVS.DesignPatterns.Behavioral.Command
{
    public class AppUser
    {
        // Initializers
        private readonly Calculator _calculator = new Calculator();
        private readonly List<Commander> _commanders = new List<Commander>();
        private int _total;

        public void Add(char mOperator, int value)
        {
            var commander = new CalculatorCommand(mOperator, value, _calculator);
            commander.Run();

            _commanders.Add(commander);
            _total++;
        }

        public void Return(int level)
        {
            Console.WriteLine("\n---- Returning {0} levels ", level);
            for (int i = 0; i < level; i++)
            {
                if (_total >= _commanders.Count - 1) continue;
                var commander = _commanders[_total++];
                commander.Run();
            }
        }

        public void UnMake(int level)
        {
            Console.WriteLine("\n---- Unmanking {0} levels ", level);
            for (int i = 0; i < level; i++)
            {
                if (_total <= 0) continue;
                var commander = _commanders[--_total];
                commander.UnMake();
            }
        }
    }
}
