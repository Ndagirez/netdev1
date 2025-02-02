﻿// See https://aka.ms/new-console-template for more information
using System;
using System.Net.WebSockets;
using System.Numerics;


Console.WriteLine("FUN WITH BASIC DATA TYPES");
LocalVarDeclarations();
DefaultDeclaration();
NewDataType();
NewKeywordSimplified();
DataTypeFunctionality();
ObjectFunctionality();
CharFunctionality();
ParseFromStrings();
ParseFromStringsWithTryParse();
UseDateaAndTimes();
UseBigInteger();
DigitSeparators();
BinaryLiterals();
static void LocalVarDeclarations()
{
    Console.WriteLine("=> Data Declarations:");
    // Local variables are declared and initialized as follows:
    // dataType varName = initialValue;
    int myInt = 0;
    
    // You can also declare and assign on two lines.
    string myString;
    myString = "this is my new string";
   
    /*It is also permissible to declare multiple variables of the same underlying type on a single line of code,
as in the following three bool variables:declare three bools on a single line*/
    bool b1= true; bool b2= false; bool b3 = b1;

    //USING SYSTEM BOOLEAN TO DECLARE A VARIABLE
   System.Boolean b4 = false;
    // printing all the variables 
    Console.WriteLine("your data :{0},{1},{3},{2},{3},{4}", myInt, myString, b1, b2, b3, b4);
    Console.WriteLine();


}
static void DefaultDeclaration()
{
    Console.WriteLine("=> DefaultDeclaration: ");
    int myInt1 = default;
    Console.WriteLine(myInt1);
}
static void NewDataType()
{
    // this uses the new keyword: to set datatypes to default
    Console.WriteLine("=> this is your data: ");
    bool b1 = new bool();
    int myInt2 = new int();
    double d = new double();
    DateTime dt = new DateTime();
    Console.WriteLine("{0},{1},{2},{3}", b1, myInt2, d, dt);
    Console.WriteLine( );

}

static void NewKeywordSimplified()
{
    Console.WriteLine("this is your simplified new data: ");
    bool b1 = new();
    int i = new();
    double D = new();
    DateTime dt = new();
    Console.WriteLine("{0},{1},{2},{3}", b1, i, D, dt);
    Console.WriteLine();

}
static void ObjectFunctionality()
{
    // A C# int is really a shorthand for System.Int32,
    // which inherits the following members from System.Object.
    Console.WriteLine("12.GetHashCode() = {0}", 12.GetHashCode());
    Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
    Console.WriteLine("12.ToString() = {0}", 12.ToString());
    Console.WriteLine("12.GetType() = {0}", 12.GetType());
    Console.WriteLine();
}
static void DataTypeFunctionality()
{
    Console.WriteLine("=> Data type Functionality:");
    Console.WriteLine("Max of int: {0}", int.MaxValue);
    Console.WriteLine("Min of int: {0}", int.MinValue);
    Console.WriteLine("Max of double: {0}", double.MaxValue);
    Console.WriteLine("Min of double: {0}", double.MinValue);
    Console.WriteLine("double.Epsilon: {0}", double.Epsilon);
    Console.WriteLine("double.PositiveInfinity: {0}",
    double.PositiveInfinity);
    Console.WriteLine("double.NegativeInfinity: {0}",
    double.NegativeInfinity);
    Console.WriteLine();
}
static void CharFunctionality()
{
    Console.WriteLine("=> char type Functionality:");
    char myChar = 'a';
    Console.WriteLine("char.IsDigit('a'): {0}", char.IsDigit(myChar));
    Console.WriteLine("char.IsLetter('a'): {0}", char.IsLetter(myChar));
    Console.WriteLine("char.IsWhiteSpace('Hello There', 5): {0}",
    char.IsWhiteSpace("Hello There", 5));
    Console.WriteLine("char.IsWhiteSpace('Hello There', 6): {0}",
    char.IsWhiteSpace("Hello There", 6));
    Console.WriteLine("char.IsPunctuation('?'): {0}",
    char.IsPunctuation('?'));
    Console.WriteLine();
}
static void ParseFromStrings()
{
    Console.WriteLine("=> Data type parsing:");
    bool b = bool.Parse("True");
    Console.WriteLine("Value of b: {0}", b);
    double d = double.Parse("99.884");
    Console.WriteLine("Value of d: {0}", d);
    int i = int.Parse("8");
    Console.WriteLine("Value of i: {0}", i);
    char c = Char.Parse("w");
    Console.WriteLine("Value of c: {0}", c);
    Console.WriteLine();
}
//using TryParse to pass values from string data  

static void ParseFromStringsWithTryParse()
{
    Console.WriteLine("=> Data type parsing with TryParse:");
    if (bool.TryParse("True", out bool b))
    {
        Console.WriteLine("Value of b: {0}", b);
    }
    else
    {
        Console.WriteLine("Default value of b: {0}", b);
    }
    string value = "Hello";
    if (double.TryParse(value, out double d))
    {
        Console.WriteLine("Value of d: {0}", d);
    }
    else
    {
        Console.WriteLine("Failed to convert the input ({0}) to a double and the variable was default {1}", value,d);
    }
    Console.WriteLine();
}
static void UseDateaAndTimes()
{


    Console.WriteLine("=> Dates and Times:");
// This constructor takes (year, month, day).
DateTime dt = new DateTime(2024, 10, 17);
// What day of the month is this?
Console.WriteLine("The day of {0} is {1}", dt.Date, dt.DayOfWeek);
// Month is now December.
dt = dt.AddMonths(2);
Console.WriteLine("Daylight savings: {0}", dt.IsDaylightSavingTime());
// This constructor takes (hours, minutes, seconds).
TimeSpan ts = new TimeSpan(4, 30, 0);
Console.WriteLine(ts);

// Subtract 15 minutes from the current TimeSpan and
// print the result.
Console.WriteLine(ts.Subtract(new TimeSpan(0, 15, 0)));
    Console.WriteLine("=> Dates and Times:");
    DateOnly d = new DateOnly(2021, 07, 21);
    Console.WriteLine(d);
    TimeOnly t = new TimeOnly(13, 30, 0, 0);
    Console.WriteLine(t);

}
static void UseBigInteger()
{
    Console.WriteLine("=> Use BigInteger:");
    BigInteger biggy =
    BigInteger.Parse("9999999999999999999999999999999999999999999999");
    Console.WriteLine("Value of biggy is {0}", biggy);
    Console.WriteLine("Is biggy an even value?: {0}", biggy.IsEven);
    Console.WriteLine("Is biggy a power of two?: {0}", biggy.IsPowerOfTwo);
    BigInteger reallyBig = BigInteger.Multiply(biggy,
    BigInteger.Parse("8888888888888888888888888888888888888888888"));
    Console.WriteLine("Value of reallyBig is: {0}", reallyBig);
    BigInteger reallyBig2 = biggy * reallyBig;
    Console.WriteLine("the value of really big is : {0}", reallyBig2);

}
static void DigitSeparators()
{
    Console.WriteLine("=> Use Digit Separators:");
    Console.Write("Integer:");
    Console.WriteLine(123_456);
    Console.Write("Long:");
    Console.WriteLine(123_456_789L);
    Console.Write("Float:");
    Console.WriteLine(123_456.1234F);
    Console.Write("Double:");
    Console.WriteLine(123_456.12);
    Console.Write("Decimal:");
    Console.WriteLine(123_456.12M);
    //Updated in 7.2, Hex can begin with _
    Console.Write("Hex:");
    Console.WriteLine(0x_00_00_FF);
}
static void BinaryLiterals()
{
    //Updated in 7.2, Binary can begin with _
    Console.WriteLine("=> Use Binary Literals:");
    Console.WriteLine("Sixteen: {0}", 0b_0001_0000);
    Console.WriteLine("Thirty Two: {0}", 0b_0010_0000);
    Console.WriteLine("Sixty Four: {0}", 0b_0100_0000);
}



