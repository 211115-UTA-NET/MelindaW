// See https://aka.ms/new-console-template for more information
using System;
using System.Reflection;
using System.Text.RegularExpressions;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Starting Calculator.");
            Console.WriteLine("Enter 'Q' to quit.");
            
            // call the calculator method
            Calculator();

            Console.WriteLine("Exiting Calculator.");
        }

        public static void Calculator()
        {
            bool isRunning = true;
            while (isRunning)
            {
                // Create a List to store each number and operator
                List<string> problem = new List<string>();
                string input;

                Console.WriteLine("Would you like to read from a "
                    + "file or enter input into the console?");
                Console.WriteLine("Enter F for file and C for "
                    + "console.");

                input = Console.ReadLine();
                input = input.ToLower();

                if(input == "f")
                {
                    Console.WriteLine("Enter in the file path of "
                    + "the txt file you want to read.");
                    input = Console.ReadLine();
                    string pattern = @"\.txt$";
                    Regex regex = new Regex(pattern);
                    Match match = regex.Match(input);
                    bool isTxtFile = match.Success;
                    input = input.ToLower();
                    if(isTxtFile)
                    {
                        try
                        {
                            StreamReader readFileLine
                                = new StreamReader(input);
                            input = readFileLine.ReadLine();
                            while(input != null)
                            {
                                input = input.ToLower();
                                input = FormatInput(input);
                                // Process user input
                                problem = ProcessInput(input);


                                string soultion = SolveProblem(problem);
                                if(soultion == "Error")
                                {
                                    Console.WriteLine(soultion);
                                }
                                else
                                {
                                    Console.WriteLine(x + "=" + soultion);
                                    try
                                    {
                                        string docPath
                                            = Path.Combine(Path.GetDirectoryName(
                                                Assembly.GetExecutingAssembly().Location),
                                                @"MathData\Write_Math.txt");
                                        StreamWriter writeToFile = new StreamWriter(docPath, true);
                                        writeToFile.WriteLine(x + "=" + soultion);
                                        writeToFile.Close();
                                    }
                                    catch(Exception e)
                                    {
                                        Console.WriteLine("Exception: " + e.Message);
                                    }
                                }
                                input = readFileLine.ReadLine();
                            }
                            readFileLine.Close();
                            Calculator();
                            break;
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("Exception: " + e.Message);
                            Calculator();
                            break;
                        }
                    }
                    else if(input == "q")
                    {
                        isRunning = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Your file must be of type .txt.");
                    }
                }
                else if(input == "c")
                {
                    // Ask the user for input
                    Console.WriteLine("Enter your problem and press enter to solve.");

                    // Read the users input
                    input = Console.ReadLine();
                    input = input.ToLower();
                    if(input == "")
                    {
                        Calculator();
                        break;
                    }
                    else if(input == "q")
                    {
                        isRunning = false;
                        break;
                    }
                    
                    input = FormatInput(input);
                    // Process user input
                    problem = ProcessInput(input);

                    string x = "";
                        
                    foreach (string value in problem)
                    {
                        x+=value;
                    }
                    string soultion = SolveProblem(problem);
                    if(soultion == "Error")
                    {
                        Console.WriteLine(soultion);
                    }
                    else
                    {
                        Console.WriteLine(x + "=" + soultion);
                        try
                        {
                            StreamWriter writeToFile = new StreamWriter("C:\\Write_Math.txt");
                            writeToFile.WriteLine(x + "=" + soultion);
                            writeToFile.Close();
                        }
                        catch(Exception e)
                        {
                            Console.WriteLine("Exception: " + e.Message);
                        }
                    }
                }
                else if (input == "")
                {
                    Calculator();
                    break;
                }
                else if (input == "q")
                {
                    isRunning = false;
                }
            }
        }

        public static string FormatInput(string input)
        {
            string[] operators = {"negative","plus","minus","multiply","divide"};
            string[] symbols = {"-","+","-","*","/"};
            string[] digitsArray = {"zero","one","two","three","four","five","six","seven","eight","nine"};
            string[] tenToNineteen = {"ten","eleven","twelve","thirteen","fourteen","fifteen","sixteen",
                "seventeen","eighteen","nineteen"};
            string[] twentyToNinety = {"twenty","thirty","forty","fifty","sixty","seventy","eighty","ninety"};
            string[] onehundredToNinehundred = {"onehundred","twohundred","threehundred","fourhundred",
                "fivehundred","sixhundred","sevenhundred","eighthundred","ninehundred"};
            
            // remove spaces
            input = input.Replace(" ", "");

            // if input has repeated values for example one one give error
            for(int i = 0; i < onehundredToNinehundred.Length; i++)
            {
                for(int j = 0; j < onehundredToNinehundred.Length; j++)
                {
                    if(input.Contains(onehundredToNinehundred[i] + onehundredToNinehundred[j]))
                    {
                        input = "Error";
                        break;
                    }
                }
            }

            for(int i = 0; i < digitsArray.Length; i++)
            {
                for(int j = 0; j < digitsArray.Length; j++)
                {
                    if(input.Contains(digitsArray[i] + digitsArray[j]))
                    {
                        input = "Error";
                        break;
                    }
                }
            }

            for(int i = 0; i < operators.Length; i++)
            {
                input = input.Replace(operators[i], symbols[i]);
            }

            for(int i = 0; i < onehundredToNinehundred.Length; i++)
            {
                for(int j = 0; j < twentyToNinety.Length; j++)
                {
                    for (int k = 1; k < digitsArray.Length; k++)
                    {
                        input = input.Replace(onehundredToNinehundred[i] + twentyToNinety[j] + digitsArray[k],
                        (i + 1).ToString() + (j + 2).ToString() + (k).ToString());
                    }
                }
            }
            
            // one hundred ten to one hundred nineteen
            for(int i = 0; i < onehundredToNinehundred.Length; i++)
            {
                for(int j = 0; j < tenToNineteen.Length; j++)
                {
                    input = input.Replace(onehundredToNinehundred[i] + tenToNineteen[j],
                    (i + 1).ToString() + "1" + j.ToString());
                }
            }

            // one hundred one to nine hundred nine skipping hundreds
            for(int i = 0; i < onehundredToNinehundred.Length; i++)
            {
                for(int j = 1; j < digitsArray.Length; j++)
                {
                    input = input.Replace(onehundredToNinehundred[i] + digitsArray[j],
                    (i + 1).ToString() + "0" + j.ToString());
                }
            }

            // one hundred to nine hundred by 100s
            for(int i = 0; i < onehundredToNinehundred.Length; i++)
            {
                input = input.Replace(onehundredToNinehundred[i], (i + 1).ToString() + "00");
            }
            
            // twenty one to ninety nine
            for(int i = 0; i < twentyToNinety.Length; i++)
            {
                for(int j = 1; j < digitsArray.Length; j++)
                {
                    input = input.Replace((twentyToNinety[i] + digitsArray[j]),
                        (i + 2).ToString() + j.ToString());
                }
            }

            // twenty to ninety by 10
            for(int i = 0; i < twentyToNinety.Length; i++)
            {
                input = input.Replace(twentyToNinety[i], (i + 2).ToString() + "0");
            }

            // ten to nineteen
            for(int i = 0; i < tenToNineteen.Length; i++)
            {
                input = input.Replace(tenToNineteen[i], (i + 10).ToString());
            }

            // zero to nine
            for(int i = 0; i < digitsArray.Length; i++)
            {
                input = input.Replace(digitsArray[i], i.ToString());
            }
            
            return input;
        }
        public static List<string> ProcessInput(string input)
        {
            List<string> problem = new List<string>();
            string var = "";
            for (int i = 0; i < input.Length; i++)
            {
                int integer = 0;
                bool isInt = int.TryParse(input[i].ToString(), out integer);
                if(isInt || input[i] == '.')
                {
                    var += input[i];
                }
                else
                {
                    if(var != "")
                    {
                        problem.Add(var);
                    }
                var = input[i].ToString();
                problem.Add(var);
                var = "";
                }
                if(i == (input.Length - 1))
                {
                    problem.Add(var);
                }
            }
            return problem;
        }

        public static string SolveProblem(List<string> problem) {
            string x = "";
            foreach (string value in problem)
            {
                x+=value;
            }
            for (int i = 0; i < problem.Count; i++)
            {
                string value = problem[i];
                double a = 0;
                double b = 0;
                if (problem.Contains("*") || problem.Contains("/"))
                {
                    try
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
                    catch (Exception e)
                    {
                        Console.WriteLine("Something went wrong please try again.");
                        problem.Clear();
                        problem.Add("Error");
                    }
                }
                if (!problem.Contains("*") && !problem.Contains("/"))
                {
                    try
                    {
                        if(problem[0] == "-" || problem[0] == "+")
                        {
                            problem[1] = problem[0] + problem[1];
                            problem.RemoveRange(0, 1);
                            return SolveProblem(problem);
                        }
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
                    catch (Exception e)
                    {
                        Console.WriteLine("Something went wrong please try again.");
                        problem.Clear();
                        problem.Add("Error");
                    }
                } 
            }
            string resultString;
            double num;
            bool isDouble = Double.TryParse(problem[0], out num);
            if (isDouble)
            {
                resultString = x + "=" + problem[0];
            }
            else
            {
                problem[0] = "Error";
                resultString = problem[0];
            }
            return resultString;
        }
    }
}

// Practice Project Requirements

// Create a dotnet console application to emulate a calculator.
// Your application should (mvp):
// -Be able to accept multiple numbers
// -Perform a selected operation on those numbers
// -Display the result of the operation
// -Repeat until the user chooses to exit

// Your application could also (stretch goals):
// -Accept number values and operations in a written input format (ie. "one plus one")
// -Accept mixed format input (ie. "one plus 3")
// -Accept multiple values (ie. "2 + 3 + 4")
// -Perform multiple operations (ie. "2 - 1 + 3")
// -Store a calculation history to a file.
// -Accept inputs from a file, perform the required operations, then output those results to a file.

// You should expect to present your functioning project to the rest of the batch on Wednesday 11/30. Your presentation should be between 3 and 7 minutes, and should include a demonstration of your application running.

// This is an individual effort project. While you are encouraged to work together with the other associates in your batch, your work must be your own. Plagiarism of any work not your own will not be tolerated.
