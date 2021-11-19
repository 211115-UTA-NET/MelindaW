using System;

namespace StringManipulationChallenge
{
    public class Program
    {
        static void Main(string[] args)
        {
            string userInputString; //this will hold your users message
            int elementNum;         //this will hold the element number within the messsage that your user indicates
            char char1;             //this will hold the char value that your user wants to search for in the message.
            string fName;           //this will hold the users first name
            string lName;           //this will hold the users last name
            string userFullName;    //this will hold the users full name;
            //
            //
            //implement the required code here and within the methods below.
            //
            //
            Console.WriteLine("Please enter your message and press enter.");
            userInputString = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Please enter a number LESS THAN the length of your string and press enter");
            elementNum = int.Parse(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("For which character should I search in your original message?");
            char1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Please enter your first name.");
            fName = Console.ReadLine();
            Console.WriteLine();

            Console.WriteLine("Please enter your last name.");
            lName = Console.ReadLine();
            Console.WriteLine();
            
            userInputString = StringToUpper(userInputString);
            Console.WriteLine();
            userInputString = StringToLower(userInputString);
            Console.WriteLine();
            Console.WriteLine("Your number is:\n" + elementNum);
            Console.WriteLine();
            userInputString = StringTrim(userInputString);
            Console.WriteLine();
            StringSubstring(userInputString, elementNum);
            Console.WriteLine();
            SearchChar(userInputString, char1);
            Console.WriteLine();
            userFullName = ConcatNames(fName, lName);
            Console.WriteLine("Your full name is " + userFullName);
        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all upper case, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringToUpper(string x){
            string upperCase = x.ToUpper();
            Console.WriteLine("Your string to upper case:\n" + upperCase);
            return upperCase;
        }

        // This method has one string parameter. 
        // It will:
        // 1) change the string to all lower case, 
        // 2) print the result to the console and 
        // 3) return the new string.        
        public static string StringToLower(string x){
            string lowerCase = x.ToLower();
            Console.WriteLine("Your string to lower case:\n" + lowerCase);
            return lowerCase;
        }
        
        // This method has one string parameter. 
        // It will:
        // 1) trim the whitespace from before and after the string, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringTrim(string x){
            string trimString = x.Trim();
            Console.WriteLine("Your string without whitespace before or after the string:\n" + trimString);
            return trimString;
        }
        
        // This method has two parameters, one string and one integer. 
        // It will:
        // 1) get the substring based on the integer received, 
        // 2) print the result to the console and 
        // 3) return the new string.
        public static string StringSubstring(string x, int elementNum){
            string subString = x.Substring(elementNum);
            Console.WriteLine("Your substring starting at " + elementNum + " is:\n" + subString);
            return subString;
        }

        // This method has two parameters, one string and one char.
        // It will:
        // 1) search the string parameter for the char parameter
        // 2) return the index of the char.
        public static int SearchChar(string userInputString, char x){
            int myChar = userInputString.IndexOf(x);
            if(myChar == -1)
            {
                Console.WriteLine("Not found.");
                return myChar;
            }
            else
            {
                Console.WriteLine("Your character " + x + " was found at index " + myChar);
                return myChar;
            }
        }

        // This method has two string parameters.
        // It will:
        // 1) concatenate the two strings with a space between them.
        // 2) return the new string.
        public static string ConcatNames(string fName, string lName){
            string fullName = fName + " " + lName;
            return fullName;
        }



    }//end of program
}
