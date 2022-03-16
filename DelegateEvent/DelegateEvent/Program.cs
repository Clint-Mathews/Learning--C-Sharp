
namespace DelegateEvent
{
    class Program
    {
        // static int Square(int input) => input * input;
        static void Main(string[] args)
        {
            Console.WriteLine("App Start");

            var calculator = new Calculator();

            //Both works fine since its either a delegate or signature of delegate

            //Calculator.Calculate calc = Square;
            //var res = calculator.Execute(calc, 5);

            //var res = calculator.Execute(Square, Console.WriteLine, 5);
            var res = calculator.Execute((x) => x*x , Console.WriteLine, 5);
            // calculator.Calculate += Calculator_Calculate;
            calculator.Calculate += (obj, args) => Console.WriteLine(args.Name);
            calculator.RaiseEvent("Clint");
            //Console.WriteLine(res);

            Console.WriteLine("App Stop");

        }

        private static void Calculator_Calculate(object arg1, CalculatorEventArgs arg2)
        {
            Console.WriteLine(arg2.Name);
        }
    }
}
