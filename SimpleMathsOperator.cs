using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DelegateAssignment
{
    public delegate void OperatorOfMath(double a, double b);
    
        public class SimpleMathsOperator
        {
            public void Addition(double a, double b)
            {
                Console.WriteLine($"The addition of the two numbers is : {a + b}");
            }
            public void Subtraction(double a, double b)
            {
                Console.WriteLine($"The subtraction between of the two numbers is : {a - b}");
            }
            public void Multiplication(double a, double b)
            {
                Console.WriteLine($"The multiplication of the two numbers is : {a * b}");
            }
            public void Divide(double a, double b)
            {
                Console.WriteLine($"The division of the two numbers is : {a / b}");
            }

            public void PrintResult (OperatorOfMath operatorOfMath)
            {
                operatorOfMath(12, 3);
            }
        }
    
}