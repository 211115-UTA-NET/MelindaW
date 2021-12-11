// See https://aka.ms/new-console-template for more information
string testString = "abcdefghijklmnopqrstuvwxyz";
Console.WriteLine(testString);

//Concatenation - n a series of interconnected things or events
//line up multiple strings one after another.

// string one = "this is a string";

// string two = "this is a different string";

// Console.WriteLine(one + two);
// Console.WriteLine(one);

//read individual characters
char myChar = testString[0];
Console.WriteLine(myChar);

//find the length of a string of characters
//length function will return the length of the string;
Console.WriteLine(testString.Length);

//Change cases to upper case, to lower case
testString = testString.ToUpper();
Console.WriteLine(testString);

testString = testString.ToLower();
Console.WriteLine(testString);

//chage case of a specific letter to upper or to lower case.


//trim end, trim start, trim
string badSpacing = "            hello           world         ";
Console.WriteLine("start" + badSpacing + "end");
Console.WriteLine("start" + badSpacing.TrimStart() + "end");
Console.WriteLine("start" + badSpacing.TrimEnd() + "end");
Console.WriteLine("start" + badSpacing.Trim() + "end");

//break down a string into component characters
string betterSpacing = "hello world";
Console.WriteLine(betterSpacing.Substring(6));

//compare the contents of a string