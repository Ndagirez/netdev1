// See https://aka.ms/new-console-template for more information
using System.Net.Security;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Numerics;
BasicStringFunctionality();

StringConcatination();

EscapeChars();

StringInterpolation();

StringInterpolationWithDefaultInterpolatedStringHandler();
//StringEquality();
StringsAreImmutabe();

StringsAreImmutable2();

FunWithStringBuilder();

ProcessBytes();
Console.ReadLine();





static void BasicStringFunctionality()
{
    Console.WriteLine("this is the basic string functionality data : ");
    string Firstname = "Mariam";
    Console.WriteLine("the name is : {0}", Firstname);
    Console.WriteLine("firstname has : {0} characters", Firstname.Length);
    Console.WriteLine("the firstname : {0} to upper laters", Firstname.ToUpper());
    Console.WriteLine("the first name: {0} to lower latters", Firstname.ToLower());
    Console.WriteLine("the name contains letter y? : {0} ", Firstname.Contains("y"));
    Console.WriteLine("new firstname : {0} ", Firstname.Replace("ri","45"));
    Console.WriteLine();

}
  
static void StringConcatination()
{
    Console.WriteLine("=>this is concatination of strings data: ");
    string s1 = "this is really";
    string s2 = " looking nice";
    string s3 = s1 + s2;
    Console.WriteLine(s3);
    Console.WriteLine();
}
static void EscapeChars()
{
    Console.WriteLine("=> Escape characters:");
    string strWithTabs = "Model\tColor\tSpeed\tPet Name ";
    Console.WriteLine(strWithTabs);
    Console.WriteLine("Everyone loves \"Hello World\" ");
    Console.WriteLine("C:\\MyApp\\bin\\Debug ");
    // Adds a total of 4 blank lines (3 escaped, 1 from WriteLine).
    Console.WriteLine("All finished.\n\n\n ");
    //omitted for brevity
    // Adds a 4 more blank lines.
    Console.WriteLine("All finished for real this time.{0}{0}{0}", Environment.NewLine);
    Console.WriteLine();
}
static void StringInterpolation()
{
    Console.WriteLine("=> this is data from an interporated string: ");
    //variables
    int age = 4;
    string MyName = "Mariam";
    //using curly bracket syntax
   string greeting = string.Format("\thello  {0} you are {1} years old ", MyName.ToUpper(), age);
    Console.WriteLine(greeting);
    //using string interporlation
    string greeting2 = $"\thello {MyName.ToUpper()} you are {age} years old";
    Console.WriteLine(greeting2);
    Console.WriteLine();
}
static void StringInterpolationWithDefaultInterpolatedStringHandler()
{
    Console.WriteLine("=> String interpolation under the covers:\a");
    int age = 4;
    string name = "Soren";
    var builder = new DefaultInterpolatedStringHandler(3, 2);
    builder.AppendLiteral("\tHello ");
    builder.AppendFormatted(name);
    builder.AppendLiteral(" you are ");
    builder.AppendFormatted(age);
    builder.AppendLiteral(" years old.");
    var greeting = builder.ToStringAndClear();
    Console.WriteLine(greeting);
    // The following string is printed verbatim,
    // thus all escape characters are displayed
    Console.WriteLine(@"C:\MyApp\bin\Debug");
    //maintaining white spaceswith verbatim
    string myString = @"My uncle went
        to london he
                is coming back
                        next year";
    Console.WriteLine(myString);
    // inserting double quotes with verbatim
    Console.WriteLine(@"this is ""quite "" interensting");

    string interp = "interporlation";
    string mylongString = $@"this string
                                    is to
                                            long with {interp}";
    Console.WriteLine(mylongString);
}
/*static void StringEqualitySpecifyingCompareRules()
{
    Console.WriteLine("=> String equality:");
    string s1 = "Hello!";
    string s2 = "Yo!";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();
    // Test these strings for equality.
    Console.WriteLine("s1 == s2: {0}", s1 == s2);
    Console.WriteLine("s1 == Hello!: {0}", s1 == "Hello!");
    Console.WriteLine("s1 == HELLO!: {0}", s1 == "HELLO!");
    Console.WriteLine("s1 == hello!: {0}", s1 == "hello!");
    Console.WriteLine("s1.Equals(s2): {0}", s1.Equals(s2));
    Console.WriteLine("Yo!.Equals(s2): {0}", "Yo!".Equals(s2));
    Console.WriteLine(); 
} 
*/

/*static void StringEquality()
{
    Console.WriteLine("=> String equality (Case Insensitive:");
    string s1 = "Hello!";
    string s2 = "HELLO!";
    Console.WriteLine("s1 = {0}", s1);
    Console.WriteLine("s2 = {0}", s2);
    Console.WriteLine();
    // Check the results of changing the default compare rules.
    Console.WriteLine("Default rules: s1={0},s2={1}s1.Equals(s2): {2}", s1, s2,
    s1.Equals(s2));
    Console.WriteLine("Ignore case: s1.Equals(s2, StringComparison.OrdinalIgnoreCase): {0}",
    s1.Equals(s2, StringComparison.OrdinalIgnoreCase));
    Console.WriteLine($"Ignore case, Invariant Culture: s1.Equals(s2, StringComparison. InvariantCultureIgnoreCase): {s1.Equals(s2, StringComparison.OrdinalIgnoreCase)}");
    Console.WriteLine();
    Console.WriteLine("Default rules: s1={0},s2={1} s1.IndexOf(\"E\"): {2}", s1, s2,s1.IndexOf("E"));
    Console.WriteLine("Ignore case: s1.IndexOf(\"E\", StringComparison.OrdinalIgnoreCase){ 0}", s1.IndexOf("E", StringComparison.OrdinalIgnoreCase));
    Console.WriteLine("Ignore case, Invariant Culture: s1.IndexOf(\"E\", StringComparison.InvariantCultureIgnoreCase): { 0}", s1.IndexOf("E", StringComparison.InvariantCultureIgnoreCase));
    Console.WriteLine();
}*/


static void StringsAreImmutabe()
{
    Console.WriteLine("=>Strings are immutable:\a ");
    //the example set initial string value
    string s1 = "hello mariam how are you";
    Console.WriteLine("s1 : {0}", s1);
    
    //to upper  string
    string upperstring=s1.ToUpper();
    Console.WriteLine("upperstring:{0}", upperstring);
    // Nope! s1 is in the same format!
    Console.WriteLine("s1 = {0}", s1);

}

static void StringsAreImmutable2()
{
    Console.WriteLine("=> string are immutable");
    string s2 = "my other string";
    s2 = "new string Value";
    Console.WriteLine(s2);
}
static void FunWithStringBuilder()
{
    Console.WriteLine("=>fun with string builder");
    StringBuilder sb = new StringBuilder("**fantastic games**",256);
    sb.Append("\n");
    sb.AppendLine("Half life");
    sb.AppendLine("Marrowind");
    sb.AppendLine("Deus EX" + "2");
    Console.WriteLine(sb.ToString());
    sb.Replace("2", "invisible war");
    Console.WriteLine(sb.ToString());
    Console.WriteLine("sb has :{0} char",sb.Length);
    Console.WriteLine();


}

Console.WriteLine("***fun WQith conversions****");
//add two short numbers and print the results
Console.WriteLine("***** Fun with type conversions *****");
// Add two shorts and print the result.
short numb1 = 30000, numb2 = 30000;
short answer = (short)Add(numb1, numb2);
Console.WriteLine("{0} + {1} = {2}", numb1, numb2, answer);
NarrowingAttempt();
Console.ReadLine();
static int Add(int x, int y)
{
    return x + y;
}
// Another compiler error!
static void NarrowingAttempt()
{
    byte myByte = 0;
    int myInt = 200;
    myByte = (byte)myInt;
    Console.WriteLine("Value of myByte: {0}", myByte);
}
//using static keyword
/*byte b1 = 100;
byte b2 = 250;
byte sum = (byte)Add(b1, b2);

// sum should hold the value 350. However, we find the value 94!
Console.WriteLine("sum = {0}", sum);*/

//modifying to remove overflow
static void ProcessBytes()
{
    byte b1 = 100;
    byte b2 = 250;
    // This time, tell the compiler to add CIL code
    // to throw an exception if overflow/underflow
    // takes place.
    try
    {
        byte sum = checked((byte)Add(b1, b2));
        Console.WriteLine("sum is:{0}", sum);
    }
    catch (OverflowException ex)
    {
        Console.WriteLine(ex.Message);
    }
    unchecked
    {
        byte sum = (byte)(b1 + b2);
        Console.WriteLine("sum = {0} ", sum);
    }


}
// Assuming /checked is enabled,
// this block will not trigger
// a runtime exception.
