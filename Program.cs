using System;

namespace LambdaAction
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lambda using Action\n");

            Action<int, int> sumAction = (int firstNumber, int secondNumber) => Console.WriteLine($"Sum is {firstNumber + secondNumber}");

            Action<int, int> differenceAction = (int firstNumber, int secondNumber) => Console.WriteLine($"Difference is {firstNumber - secondNumber}");

            Action<int, int> multiplicationAction = (int firstNumber, int secondNumber) => Console.WriteLine($"Product is {firstNumber * secondNumber}");

            Action<int, int> divisionAction = (int firstNumber, int secondNumber) => Console.WriteLine($"Quotient is {firstNumber / secondNumber}");

            Calculator(sumAction, 9, 3);
            Calculator(differenceAction, 9, 3);
            Calculator(multiplicationAction, 9, 3);
            Calculator(divisionAction, 9, 3);

        }
        static void Calculator(Action<int, int> ActionCalculator, int firstNumber, int secondNumber)
        {
            ActionCalculator(firstNumber, secondNumber);
        }
    }
}
