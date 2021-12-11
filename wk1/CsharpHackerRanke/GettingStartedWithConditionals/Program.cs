// See https://aka.ms/new-console-template for more information
char input;

Console.WriteLine("Enter Y for yes or N for no.");
input = Convert.ToChar(Console.ReadLine());

if (input == 'Y' || input == 'y') {
    Console.WriteLine("Yes");
}
if (input == 'N' || input == 'n') {
    Console.WriteLine("NO");
}