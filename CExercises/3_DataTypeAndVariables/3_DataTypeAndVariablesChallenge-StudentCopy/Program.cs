using System;

namespace _3_DataTypeAndVariablesChallenge
{
    public class Program
    {
      public static void Main(string[] args)
      {

          byte myByte = 99;
          Console.WriteLine("myByte: " + myByte);

          sbyte mySbyte = -20;
          Console.WriteLine("mySbyte: " + mySbyte);

          int myInt = 777777;
          Console.WriteLine("myInt: " + myInt);

          uint myUint = 5559998;
          Console.WriteLine("myUnit: " + myUint);

          short myShort = -8956;
          Console.WriteLine("myShort: " + myShort);

          ushort myUShort = 11111;
          Console.WriteLine("myUShort: " + myUShort);

          long myLong = -10;
          Console.WriteLine("myLong: " + myLong);

          ulong myULong = 22;
          Console.WriteLine("myUlong: " + myULong);

          float myFloat = 10;
          Console.WriteLine("myFloat: " + myFloat);

          double myDouble = 10.1;
          Console.WriteLine("myDouble: " + myDouble);

          char myCharacter = 'B';
          Console.WriteLine("myCharacter: " + myCharacter);

          bool myBool = true;
          Console.WriteLine("myBool: " + myBool);

          decimal myDecimal = 10;
          Console.WriteLine("myDecimal: " + myDecimal);

          string myText = "I control text";
          Console.WriteLine("myText: " + myText);

          string numText = "10102";
          Console.WriteLine("numText: " + numText);
          
          int isParsed = Text2Num(numText);
          if (isParsed == -1)
          {
            Console.WriteLine("The string could not be parsed.");
          }
          else
          {
            Console.WriteLine("The parsed string is: " + isParsed);
          }
          
      }

      public static int Text2Num(string numText)
      {
        int parsedString;
        bool isConverted = int.TryParse(numText, out parsedString);
        if(isConverted)
        {
          return parsedString;
        }
        else
        {
          return -1;
        }
      }
    }
}
