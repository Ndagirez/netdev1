// See https://aka.ms/new-console-template for more information
using System.Security.Cryptography.X509Certificates;



ForLoopExample();
ForEachloopExample();
LinqInForeachLoopExample();
//WhileLoopExmple();
//DoWhileLoopExample();
IfElseStatement();
IfElsePatternMatching();
IfElsePatternMatchingUpdatedInCSharp9();
ConditionlOperaterAsIfStatement();
ConditionalRefExample();
SwitchExample();
SwitchStatementwithStrings();
SwitchOnEnumExample();
ExecutePatternMatchingSwitch();
ExecutePatternMatchingSwitchWithWhen();




    static void ForLoopExample()
{
    // Note! "i" is only visible within the scope of the for loop.
    for (int i = 0; i < 4; i++)
    {
        Console.WriteLine("Number is: {0}",i);
    }
    //i is not visible 
}
static void ForEachloopExample()
{
    string[] CarTypes = { "FORD", "Yugo", "BMW", "HONDA" };
    foreach (string C in CarTypes)
    {
    Console.WriteLine(C);
    }
    int[] myInt = { 10, 20, 30, 40 };
    foreach (int i in myInt)
    {
        Console.WriteLine(i);
    }
}
static void LinqInForeachLoopExample()
{
    int[] numbers = {10, 20, 30, 40, 1, 2, 3, 8 };
    var subset = from i in numbers where i < 10 select i;
    Console.WriteLine("value in subset: ");
    foreach( var i in subset)
    {
    Console.WriteLine("{0}", i);
    }


}
// using while and do while loop constructions

static void WhileLoopExmple()
{
    string UserIsDone = "";
    // testing on lower case of string
    while (UserIsDone.ToLower() != "yes")
    {
        Console.WriteLine("in while loop");
        Console.WriteLine("Are you done [yes][no]: ");
        UserIsDone = Console.ReadLine();
    }

}
static void DoWhileLoopExample()
{
    string userIsDone1 = "";
    do
    {
        Console.WriteLine("In do/while loop");
        Console.Write("Are you done? [yes] [no]: ");
        userIsDone1 = Console.ReadLine();
    } while (userIsDone1.ToLower() != "yes"); // Note the semicolon!
}
for (int i = 0; i < 10; i++)
    Console.WriteLine("{0}", i);// used when you dont have more lines here*/
// working with decisions and relational/quaity operators
//if/else statements
//switch statements*/

static void IfElseStatement()
{
    Console.WriteLine("=> This is the data from if else: ");
    string one = "My Name Is Mariam";
    if (one.Length > 10)
    {
        Console.WriteLine("this is the answer:{0} ", one);
    }
    else
    {
        Console.WriteLine("THE STRING IS NOT LESS THAN 10");
    }
}
static void IfElsePatternMatching()
{
    Console.WriteLine("===If Else Pattern Matching ===");
    object testItem1 = 123;
    object testItem2 = "Hello";
    if (testItem1 is string myStringValue1)
    {
        Console.WriteLine($"{myStringValue1} is a string");
    }
    if (testItem1 is int myValue1)
    {
        Console.WriteLine($"{myValue1} is an int");
    }
    if (testItem2 is string myStringValue2)
    {
        Console.WriteLine($"{myStringValue2} is a string");
    }
    if (testItem2 is int myValue2)
    {
        Console.WriteLine($"{myValue2} is an int");
    }
    Console.WriteLine();
}
static void IfElsePatternMatchingUpdatedInCSharp9()
{
    Console.WriteLine("======= C# 9 If Else Pattern Matching Improvements =======");
    object testItem1 = 123;
    Type t = typeof(string);
    char c = 'f';
    //Type patterns
    if (t is Type)
    {
        Console.WriteLine($"{t} is a Type");
    }
    //Relational, Conjuctive, and Disjunctive patterns
    if (c is >= 'a' and <= 'z' or >= 'A' and <= 'Z')
    {
        Console.WriteLine($"{c} is a character");
    };
    //Parenthesized patterns
    if (c is (>= 'a' and <= 'z') or (>= 'A' and <= 'Z') or '.' or ',')
    {
        Console.WriteLine($"{c} is a character or separator");
    };
    //Negative patterns
    if (testItem1 is not string)
    {
        Console.WriteLine($"{testItem1} is not a string");
    }
    if (testItem1 is not null)
    {
        Console.WriteLine($"{testItem1} is not null");
    }
    Console.WriteLine();
}
// using conditional operator
static void ConditionlOperaterAsIfStatement()
{
    string myString2 = "helo MARIAM";
    Console.WriteLine(myString2.Length < 5 ? "string length is less than 5" : "string length is greater than 5");
}
static void ConditionalRefExample()
{
    var smallArray = new int[] { 1, 2, 3, 4, 5 };
    var largeArray = new int[] { 10, 20, 30, 40, 50 };
    int index = 7;
    ref int refValue = ref ((index < 5)
    ? ref smallArray[index]
    : ref largeArray[index - 5]);
    refValue = 0;

    index = 2;
    ((index < 5)
    ? ref smallArray[index]
    : ref largeArray[index - 5]) = 100;
    Console.WriteLine(string.Join(" ", smallArray));
    Console.WriteLine(string.Join(" ", largeArray));
}
static void ExecutePatternMatchingSwitchWithWhen()
{
    Console.WriteLine("1 [C#], 2 [VB]");
    Console.Write("Please pick your language preference: ");
    object langChoice = Console.ReadLine();
    var choice = int.TryParse(langChoice.ToString(), out int c) ? c : langChoice;
    switch (choice)
    {
        case int i when i == 2:
        case string s when s.Equals("VB", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("VB: OOP, multithreading, and more!");
            break;
        case int i when i == 1:
        case string s when s.Equals("C#", StringComparison.OrdinalIgnoreCase):
            Console.WriteLine("Good choice, C# is a fine language.");
            break;
        default:
            Console.WriteLine("Well...good luck with that!");
            break;
    }
    Console.WriteLine();
}
// Switch on a numerical value.
static void SwitchExample()
{
    Console.WriteLine("1 [C#], 2 [VB]");
    Console.Write("Please pick your language preference: ");
    string langChoice = Console.ReadLine();
    int n = int.Parse(langChoice);
    switch (n)
    {
        case 1:
            Console.WriteLine("Good choice, C# is a fine language.");
            break;
        case 2:
            Console.WriteLine("VB: OOP, multithreading, and more!");
            break;
        default:
            Console.WriteLine("Well...good luck with that!");
            break;
    }
}
static void SwitchStatementwithStrings()
{
    Console.WriteLine("=>theis is c# evaluating strings");
    Console.WriteLine("C# OR VB");
    Console.Write("Please pick your language preference: ");

    string LanguageChoice= Console.ReadLine();
    switch (LanguageChoice.ToUpper())
    {
        case "C#":
            Console.WriteLine("C# IS A VERY BEAUTIFUL LANGUAGE");
            break;
        case "VB":
            Console.WriteLine("VB: AN OOP LANGUAGE");
            break;
        default:
            Console.WriteLine("wish you well with that");
            break;
    }
}//
static void SwitchOnEnumExample()
{
    Console.Write("Enter your favorite day of the week: ");
    DayOfWeek favDay;
    try
    {
        favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
    }
    catch (Exception)
    {
        Console.WriteLine("Bad input!");
        return;
    }
    switch (favDay)
    {
        case DayOfWeek.Sunday:
            Console.WriteLine("Football!!");
            break;
        case DayOfWeek.Monday:
            Console.WriteLine("Another day, another dollar");
            break;
        case DayOfWeek.Tuesday:
            Console.WriteLine("At least it is not Monday");
            break;
        case DayOfWeek.Wednesday:
            Console.WriteLine("A fine day.");
            break;
        case DayOfWeek.Thursday:
            Console.WriteLine("Almost Friday...");
            break;
        case DayOfWeek.Friday:
            Console.WriteLine("Yes, Friday rules!");
            break;
        case DayOfWeek.Saturday:
            //DayOfWeek.Sunday. here , both saturday and sunday will yield the same result in the console
            Console.WriteLine("Great day indeed.");
            break;
    }
    Console.WriteLine();
}
static void ExecutePatternMatchingSwitch()
{
    Console.WriteLine("1 [Integer (5)], 2 [String (\"Hi\")], 3 [Decimal (2.5)]");
    Console.Write("Please choose an option: ");
    string userChoice = Console.ReadLine();
    object choice;
    //This is a standard constant pattern switch statement to set up the example
    switch (userChoice)
    {
        case "1":
            choice = 5;
            break;
        case "2":
            choice = "Hi";
            break;
        case "3":
            choice = 2.5M;
            break;
        default:
            choice = 5;
            break;
    }
    //This is new the pattern matching switch statement
    switch (choice)
    {
        case int i:
            Console.WriteLine("Your choice is an integer.");
            break;
        case string s:
            Console.WriteLine("Your choice is a string.");
            break;
        case decimal d:
            Console.WriteLine("Your choice is a decimal.");
            break;
        default:
            Console.WriteLine("Your choice is something else");
            break;
    }
    Console.WriteLine();
}

static string FromRainbowClassic(string colorBand)
{
    switch (colorBand)
    {
        case "Red":
            return "#FF0000";
        case "Orange":
            return "#FF7F00";
        case "Yellow":
            return "#FFFF00";
        case "Green":
            return "#00FF00";
        case "Blue":
            return "#0000FF";
        case "Indigo":
            return "#4B0082";
        case "Violet":
            return "#9400D3";
        default:
            return "#FFFFFF";
    };
}
Console.WriteLine(FromRainbowClassic("Green"));
static string FromRainbow(string colorBand)
{
    return colorBand switch
    {
        "Red" => "#FF0000",
        "Orange" => "#FF7F00",
        "Yellow" => "#FFFF00",
        "Green" => "#00FF00",
        "Blue" => "#0000FF",
        "Indigo" => "#4B0082",
        "Violet" => "#9400D3",
        _ => "#FFFFFF",
    };
}