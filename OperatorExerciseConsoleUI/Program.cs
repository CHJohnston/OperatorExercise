using Microsoft.VisualBasic;
using System;

namespace OperatorExerciseConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //Exercise #1 C# Operators 

            Console.WriteLine("Let's Do Some Fun Math!!");
            Console.WriteLine("Enter a number");
            
            int firstNum = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter another number");
            int secondNum = int.Parse(Console.ReadLine());

            int additionAnswer = Addition(firstNum, secondNum);
            Console.WriteLine($"The Sum is {additionAnswer}");

            int subtractionAnswer = Subtraction(firstNum, secondNum);
            Console.WriteLine($"The Difference is {subtractionAnswer}");

            int multiplicationAnswer = Multiplication(firstNum, secondNum);
            Console.WriteLine($"The Product is {multiplicationAnswer}");

            if (secondNum == 0)
            {
                Console.WriteLine($"The Second Number called the Divisor can't be a 0. The result is invalid ");
            }
            else
            {
                int quotientAnswer = Division(firstNum, secondNum);               
                int remainderAnswer = Modulus(firstNum, secondNum);
                Console.WriteLine($"{firstNum} divided by {secondNum} is {quotientAnswer} with a remainder of {remainderAnswer}");
            }

            //Exercise #2 - Use a method to calculate the area of a circle and print the result
            Console.WriteLine();
            Console.WriteLine("Let's try something else, Enter a number for the radius of a circle");
            var radius = double.Parse(Console.ReadLine());
            var area = AreaFinder(radius);
            Console.WriteLine($"The area of your circle is {area}");

        }        public static int Addition(int num1, int num2)
        {//Addition Method
            var result = num1 + num2;
            return result;
        }
        public static int Subtraction(int num1, int num2)
        {//Subtraction Method
            var result = num1 - num2;
            return result;
        }
        public static int Multiplication(int num1, int num2)
        {//Multiplication Method
            var result = num1 * num2;
            return result;
        }
        public static int Division(int num1, int num2)
        {// Division Method                  
            var result = num1 / num2;
            return result;
        }
        public static int Modulus(int num1, int num2)
        {// Modulus Method                  
            var result = num1 % num2;
            return result;
        }
        public static double AreaFinder(double radius)
        {// Exercise #2
         //  return Math.PI * Math.Pow(radius, 2);  Note - this option uses the Math method for pi and the Math Method for power
             return Math.PI * radius * radius;     
        }
    }
}