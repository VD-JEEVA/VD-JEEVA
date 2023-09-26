using System;

namespace Calculator
{
    public class main
    {
        static void Main(string[] args)
        {
            //Console.Write("Hey, Enter your first number... ");
            //int firstNumber = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Hey, Enter your second number... ");
            //int secondNumber = Convert.ToInt32(Console.ReadLine());

            AdvancedCalculator calc = new AdvancedCalculator();
            Console.WriteLine(calc.add(1, 2));
            Console.WriteLine(calc.subtract(2, 1));
            Console.WriteLine(calc.multiply(1, 2));
            try
            {
                //Console.WriteLine(calc.divide(firstNumber, secondNumber));
                Console.WriteLine(calc.divide(2, 0));
            }
            catch (ArgumentException e)
            {
                Console.WriteLine(e.Message);
            }
            Console.WriteLine(calc.squareRoot(5));
        }
    }
}