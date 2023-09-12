// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter the first number: ");
double num1 = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Enter the secound number: ");
double num2 = Convert.ToDouble(Console.ReadLine());

double sum = num1 + num2;

Console.WriteLine($"The sum of {num1} and {num2} is {sum}");