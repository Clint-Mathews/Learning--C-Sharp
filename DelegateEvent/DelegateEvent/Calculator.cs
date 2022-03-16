using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEvent
{
    public class Calculator
    {
        // public delegate int Calculate(int input);
        // public delegate void Print(int input);

        public event Action<object, CalculatorEventArgs> Calculate;

        public void RaiseEvent(string name)
        {
            Calculate?.Invoke(this, new CalculatorEventArgs() { Name = name});
        }

        public int Execute(Func<int,int> calculate, Action<int> print, int input)
        {
            // return calculate.Invoke(input);
            
            var res = calculate.Invoke(input);
            print(res);
            return res;
        }

    }
}
