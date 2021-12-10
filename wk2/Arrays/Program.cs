// See https://aka.ms/new-console-template for more information
static void Main() {
    int newInt = 8;

    int[] intArray = new int[] {3, 4, 5};
    int[] secondIntArray = new int[5];

    Console.WriteLine("newInt = " + newInt);
    Console.WriteLine("intArray = " + intArray[0]);
    PrintArray(intArray);

    Stack<string> names = new Stack<string>();
    names.Push("Jill");
    names.Push("Tim");
    names.Push("Tom");

    foreach( string name in names ) {
        Console.WriteLine(name);
    }

    Console.WriteLine("\nPopping " + names.Pop());

    foreach( string name in names ) {
        Console.WriteLine(name);
    }

    Console.WriteLine("\nPopping " + names.Pop());
}

static void PrintArray( int[] Array) {
    for ( int i = 0; i < Array.Length; i++) {
        Console.WriteLine(Array[i]);
    }
}

Main();