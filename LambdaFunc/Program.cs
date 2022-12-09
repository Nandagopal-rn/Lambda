using System;

namespace LambdaFunc
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lambada With Func");

            Func<int, int, int> sumOperation = ( firstNumber, secondNumber) => firstNumber + secondNumber;

            Func<int, int, int> differenceOperation = ( firstNumber, secondNumber) => firstNumber - secondNumber;

            Func<int, int, int> multiplyOperation = ( firstNumber, secondNumber) => firstNumber * secondNumber;

            Func<float,float,float> divisionOperation = ( firstNumber, secondNumber) => firstNumber / secondNumber;

            CalculatorAddition(sumOperation, 30, 20);
            CalculatorSubstraction(differenceOperation, 30, 20);
            CalculatorMultiply(multiplyOperation, 30, 20);
            CalculatorDivision(divisionOperation, 30, 20);

        }
        static void CalculatorAddition(Func<int,int,int> sumFunc,int firstNumber,int secondNumber)
        {
            Console.WriteLine($"Sum is {sumFunc(firstNumber, secondNumber)}");
        }
        static void CalculatorSubstraction(Func<int, int, int> differenceFunc, int firstNumber, int secondNumber)
        {
            Console.WriteLine($"Difference is {differenceFunc(firstNumber, secondNumber)}");
        }
        static void CalculatorMultiply(Func<int, int, int> productFunc, int firstNumber, int secondNumber)
        {
            Console.WriteLine($"Product is {productFunc(firstNumber, secondNumber)}");
        }
        static void CalculatorDivision(Func<float,float,float> quotientFunc, int firstNumber, int secondNumber)
        {
            Console.WriteLine($"Quotient is {quotientFunc(firstNumber, secondNumber)}");
        }

    }
}
