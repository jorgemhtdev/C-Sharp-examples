namespace Events
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var calculator = new Calculator();

            //calculator.DivideByZero += CalculatorOnDivideByZero;
             
            calculator.DivideByZero += (sender, e) =>
            {
                Console.WriteLine($"Division entre {e.a},{e.b} no es posible");
            };
            

            int r = calculator.Divide(10, 0);

            Console.WriteLine(r);

            Console.ReadLine();
        }

        /*
        private static void CalculatorOnDivideByZero(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("Division entre 0");
        }
        */
    }
}
