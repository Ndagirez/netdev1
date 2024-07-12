// See https://aka.ms/new-console-template for more information
using System;
using System.Net.WebSockets;
using System.Numerics;

Console.WriteLine("FUN WITH BASIC DATA TYPES");
LocalVarDeclarations();
DefaultDeclaration();
NewDataType();
NewKeywordSimplified();
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
    Console.WriteLine( "your data :{0},{1},{3},{2},{3},{4}",  myInt, myString, b1, b2, b3, b4 );
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