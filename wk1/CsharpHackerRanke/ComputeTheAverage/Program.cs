// See https://aka.ms/new-console-template for more information
int N;
int x = 0;
Console.WriteLine("Enter the number of integers.");
N = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= N; i++) {
    Console.WriteLine("Enter integer number " + i + ": ");
    x += Convert.ToInt32(Console.ReadLine());
}
decimal xN = x;
decimal ND = N;
decimal average = (xN/ND);

Console.WriteLine(Math.Round(average, 3).ToString("F3"));