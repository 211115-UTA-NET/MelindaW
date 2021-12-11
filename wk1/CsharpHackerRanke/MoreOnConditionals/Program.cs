// See https://aka.ms/new-console-template for more information
int x;
int y;
int z;

Console.WriteLine("Enter side 1.");
x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter side 2.");
y = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter side 3.");
z = Convert.ToInt32(Console.ReadLine());

if (x == y && x == z) {
    Console.WriteLine("EQUILATERAL");
} else if (x == y || x == z || y == z) {
    Console.WriteLine("ISOSCELES");
} else {
    Console.WriteLine("SCALENE");
}