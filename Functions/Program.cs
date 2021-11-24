// See https://aka.ms/new-console-template for more information

static void Main() {
    
    for (int i = 0; i<5; i++) {
        int j = SayHello();
        Console.WriteLine(j);
    }

    int a, b;
    a = 2;
    b = 4;
    
    int c;
    c = NewFunc(a, b);
    Console.WriteLine(c);

    c = NewFunc(5, 6);

    Console.WriteLine(NewFunc(1,4));

    c = Multiply(5,6);
    Console.WriteLine(c);

    Console.WriteLine(GoodBye());
}

static int NewFunc(int x, int y) {
    int z = x + y;
    return z;
}

static int Multiply(int x, int y) {
    int z = x * y;
    return z;
}

static int SayHello() {
    Console.WriteLine("Hi, there!");
    int j = NewFunc(7,4);
    return j;
}

static string GoodBye() {
    return "Good Bye";
}

Main();