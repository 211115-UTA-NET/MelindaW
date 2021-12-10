class Age
{
    private readonly int _year;
    Age(int year)
    {
        _year = year;
    }
    void ChangeYear()
    {
        //_year = 1967;  Compile error: CS0191 A readonly field cannot be assigned to
        //                (except in a constructor or init-only setter of the type in
        //                which the field is defined or a variable initializer)
    }
}

// Values can be assigned to readonly field only:
//  * When the variable is initialized in the declaration.
class Dog
{
    private readonly int _legs = 4;
    Dog(int legs)
    {
        _legs = legs;
    }
}

//  * In an instance constructor of the class that contains the instance field declaration.
class Snake
{
    private readonly int _legs;
    Snake()
    {
        _legs = 0;
    }
}

// * In the static constructor of the class that contains the static field declaration.
class Bird
{
    private static readonly int _legs;
    static Bird()
    {
        _legs = 2;
    }
}