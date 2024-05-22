// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using DelegateAssignment;

var sort = new SimpleMathsOperator();


Console.WriteLine("=========== Welcome to Simple Math Calculator ====================\n");
Console.WriteLine("Kindly select from the option\n Press 1 for Addition");
Console.WriteLine("Press 2 for Subtraction\n Press 3 for Multiplication");
Console.WriteLine("Press 4 for Division");
int userInput = int.Parse(Console.ReadLine());
Console.WriteLine("***************\n *********");
if (userInput == 1)
{
  OperatorOfMath operatorOfMath = sort.Addition;
  sort.PrintResult(operatorOfMath);
} 
else if (userInput == 2)
{
  OperatorOfMath operatorOfMath = sort.Subtraction;
  sort.PrintResult(operatorOfMath);
}
else if (userInput == 3)
{
    OperatorOfMath operatorOfMath = sort.Multiplication;
    sort.PrintResult(operatorOfMath);
}
else if (userInput == 4)
{
    OperatorOfMath operatorOfMath = sort.Divide;
    sort.PrintResult(operatorOfMath);
}
else
{
    Console.WriteLine("Invalid input select from the options");
}
