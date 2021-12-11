// See https://aka.ms/new-console-template for more information
int x;
int y;

Console.WriteLine("Enter an intager value for x: ");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter an intager value for y: ");
y = Convert.ToInt32(Console.ReadLine());

if(x > y) {
    Console.WriteLine("x is greater than y");
} else if(x < y) {
    Console.WriteLine("x is less than y");
} else {
    Console.WriteLine("x is equal to y");
}