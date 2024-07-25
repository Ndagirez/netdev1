// See https://aka.ms/new-console-template for more information
//defining local variables implicitly
DeclareImplicitVars();
DeclareImplicitNumerics();
GetAnInt();
linQueryInts();
//ImplicitTypingIsStrongTyping();
static void DeclareImplicitVars()
{
    var myInt = 0;
    var Mybool = true;
    var myString = "this is marching on";
    Console.WriteLine("MY INT IS :{0}",myInt.GetType().Name);
    Console.WriteLine("my boolean is:{0}",Mybool.GetType().Name);
    Console.WriteLine("my string is :{0}", myString.GetType().Name);
}
static void DeclareImplicitNumerics()
{
    var myUInt = 0u;
    var MyInt = 0;
    var MyLong = 0L;
    var MyDouble = 0.5;
    var MyFloat = 0.5F;
    var MyDecimal = 0.5M;
    //PRINTING 
    Console.WriteLine("My Uint is : {0}", myUInt.GetType().Name);
    Console.WriteLine("Myint is   : {0}", MyInt.GetType().Name);
    Console.WriteLine("My LONG is : {0}", MyLong.GetType().Name);
    Console.WriteLine("My double  is : {0}", MyDouble.GetType().Name);
    Console.WriteLine("My FLOAT is : {0}", MyFloat.GetType().Name);
    Console.WriteLine("My Decimal is : {0}", MyDecimal.GetType().Name);
}
//UNDERSTANDING RESTRICTIONS ON IMPLICITLY DEFINED VARIABLES
/*class ThisWillNeverCompile
{
    // Error! var cannot be used as field data!
    private var myInt = 10;
    // Error! var cannot be used as a return value
    // or parameter type!
    public var MyMethod(var x, var y)
    { 
    }
}*/
/*// Error! Must assign a value!
var myData;//THIS IS WRONG
// Error! Must assign value at exact time of declaration!
var myInt;
myInt = 0;
// Error! Can't assign null as initial value!
var myObj = null;*/
/*var Mycar = new SportsCar();
Mycar = null;*/

static int GetAnInt()
{
    var retVal = 9;
    return retVal;
}
Console.WriteLine("my return value is : {0}",GetAnInt());
/*static void ImplicitTypingIsStrongTyping()
{
    // The compiler knows "s" is a System.String.
    var s = "This variable can only hold string data!";
    s = "This is fine...";
    // Can invoke any member of the underlying type.
    string upper = s.ToUpper();
    // Error! Can't assign numerical data to a string!
    s = 44;
}*/
static void linQueryInts()
{
    int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
    //linq querry
    var subset = from i in numbers where i < 10 select i;
    Console.WriteLine("values in subset : ");
    foreach (var i in subset)
    {
        Console.Write("{0}", i);
    }
    Console.WriteLine();
    //what type is subset?
    Console.WriteLine("subset is a :{0}", subset.GetType().Name);
    Console.WriteLine("subset is defined in: {0}", subset.GetType().Name);

}
