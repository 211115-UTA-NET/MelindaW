// See https://aka.ms/new-console-template for more information

// Practice Project Requirements

// Create a dotnet console application to emulate a calculator.
// Your application should (mvp):
// -Be able to accept multiple numbers
// -Perform a selected operation on those numbers
// -Display the result of the operation
// -Repeat until the user chooses to exit

using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;
            // Create a List to store each number and operator
            List<string> problem = new List<string>();

            Console.WriteLine("Starting Calculator.");
            Console.WriteLine("Enter '=' to solve.");
            Console.WriteLine("Enter 'Q' to quit.");

            while (isRunning)
            {
                // Ask the user for input
                Console.WriteLine("Enter a number or operator.");
                string input = Console.ReadLine();
                // Read the user input
                if(input != "=" && input != "Q")
                {
                    problem.Add(input);
                }
                else if (input == "=")
                {
                    string x = "";
                    foreach (string value in problem)
                    {
                        x+=value;
                    }
                    double soultion = SolveProblem(problem);
                    Console.WriteLine(x + "=" + soultion);
                    problem = new List<string>();
                }
                else
                {
                    isRunning = false;
                }
            }
        }

        public static double SolveProblem(List<string> problem) {
            double result = 0;
            for (int i = 0; i < problem.Count; i++)
            {
                string value = problem[i];
                double a = 0;
                double b = 0;
                if (problem.Contains("*") || problem.Contains("/"))
                {
                    switch (value)
                    {
                        case "*":
                            a = Double.Parse(problem[i - 1]);
                            b = Double.Parse(problem[i + 1]);
                            double multiple = a * b;
                            problem[i + 1] = multiple.ToString();
                            problem.RemoveRange((i - 1), 2);
                            return SolveProblem(problem);
                        case "/":
                            a = Double.Parse(problem[i - 1]);
                            b = Double.Parse(problem[i + 1]);
                            double division = a / b;
                            problem[i + 1] = division.ToString();
                            problem.RemoveRange((i - 1), 2);
                            return SolveProblem(problem);
                     }
                }
                if (!problem.Contains("*") && !problem.Contains("/"))
                {
                    switch (value)
                    {
                        case "+":
                            a = Double.Parse(problem[i - 1]);
                            b = Double.Parse(problem[i + 1]);
                            double sum = a + b;
                            problem[i + 1] = sum.ToString();
                            problem.RemoveRange((i - 1), 2);
                            return SolveProblem(problem);
                        case "-":
                            a = Double.Parse(problem[i - 1]);
                            b = Double.Parse(problem[i + 1]);
                            double diff = a - b;
                            problem[i + 1] = diff.ToString();
                            problem.RemoveRange((i - 1), 2);
                            return SolveProblem(problem);
                    }
                }
                
            }
            result = Double.Parse(problem[0]);
            return result;
        }
    }
}

// Your application could also (stretch goals):
// -Accept number values and operations in a written input format (ie. "one plus one")
// -Accept mixed format input (ie. "one plus 3")
// -Accept multiple values (ie. "2 + 3 + 4")
// -Perform multiple operations (ie. "2 - 1 + 3")
// -Store a calculation history to a file.
// -Accept inputs from a file, perform the required operations, then output those results to a file.

// You should expect to present your functioning project to the rest of the batch on Wednesday 11/30. Your presentation should be between 3 and 7 minutes, and should include a demonstration of your application running.

// This is an individual effort project. While you are encouraged to work together with the other associates in your batch, your work must be your own. Plagiarism of any work not your own will not be tolerated.
