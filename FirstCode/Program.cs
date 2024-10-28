// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

// Store and Retrieve Data Using Literal and Variable Values in C#
Console.WriteLine('b'); // character literals using single quotation
Console.WriteLine(123); // integer literals
Console.WriteLine(0.25F); // floating point literals
Console.WriteLine(true); //boolean literals

// Declaring variables
char userOption;
int gameScore;
decimal particlesPerMillion;
bool processedCustomer;

// setting and getting values 
string firstName;
firstName = "Bob";
Console.WriteLine(firstName);

string lastName;
lastName = "Bob";
Console.WriteLine(lastName);
lastName = "Liem";
Console.WriteLine(lastName);
lastName = "Isabella";
Console.WriteLine(lastName);
lastName = "Yasmin";
Console.WriteLine(lastName);


// Declaring implicitly typed local variables
var messageGreet = "Hello World!";

// Challenge
string name ="Bob" ;
int  message = 3;
double temp = 3.5; 

Console.WriteLine("Hello " + name + "!You have" + message + "messages in your inbox." + "The temperature is " + temp + "C");

int version = 11;
string updateText = "Update to Windows";
Console.WriteLine($"{updateText} {version}"); // string interpolation

// basic operation and adding numbers
string firstName2 = "Bob";
int widgetsSold = 7;
Console.WriteLine(firstName2 + " sold " + widgetsSold + 7 + " widgets"); // concatenates strings: answer = 77
Console.WriteLine(firstName2 + " sold " + (widgetsSold + 7) + " widgets");

//basic maths operation
int sum = 7 + 5;
int difference = 7 - 5;
int product = 7 * 5;
int quotient = 7 / 5;

Console.WriteLine("Sum: " + sum);
Console.WriteLine("Difference: " + difference);
Console.WriteLine("Product: " + product);
Console.WriteLine("Quotient: " + quotient);

//casting result
int first = 7;
int second = 5;
decimal quotient1 = (decimal)first / (decimal)second;
Console.WriteLine("Quotient1: " + quotient1);

//increment and decrement
int value = 1;

value = value + 1;
Console.WriteLine("First increment: " + value);

value += 1;
Console.WriteLine("Second increment: " + value);

value++;
Console.WriteLine("Third increment: " + value);

value = value - 1;
Console.WriteLine("First decrement: " + value);

value -= 1;
Console.WriteLine("Second decrement: " + value);

value--;
Console.WriteLine("Third decrement: " + value);

int fahrenheit = 94;
decimal celsius = (fahrenheit - 32m) * (5m / 9m);
Console.WriteLine("The temperature is " + celsius + " Celsius.");