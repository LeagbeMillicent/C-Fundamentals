# C-Fundamentals
#First-Code:
{Console.WriteLine("Hello World!");}

Click the Run button:
It compiles the code into an executable format that a computer can understand.
It runs the compiled application and, when written correctly, will output "Hello World!".

#Some errors that can occur
1. Case sensitivity
   a. console.writeline("Hello World"); // This is wrong
   b. Console.writeline("Hello World"); // This too is wrong
2. The use of single-quotation marks (') to surround the literal string Hello World! will throw an error
3. Not adding the semi-Colon .

# Commenting codes
adding comment to codes using two forward slashes // tells the computer not to run that code.

# "Write" and "WriteLine"
//Write
Console.Write("Congratulations!");
Console.Write(" ");
Console.Write("You wrote your first lines of code.");

//Output 
"Congratulations! You wrote your first lines of code."

//WriteLine
Console.WriteLine("Congratulations!");
Console.Write("You wrote your first lines of code.");

//OutPut
Congratulations!
You wrote your first lines of code.

# .NET Libraries
The .NET Class Library is a collection of thousands of classes containing tens of thousands of methods. For example, 
the .NET Class Library includes the Console class for developers working on console applications. 
The Console class includes methods for input and output operations such as Write(), WriteLine(), Read(), ReadLine(), and many others

-Any methods that can send or receive information from a console window are collected into the System.Console class in the .NET Class Library
-The classes and methods in the .NET Class Library are created by Microsoft and are available for use in your applications.

-To call methods of a class in the .NET Class Library, you use the format ClassName.MethodName(), where the . symbol is the member access operator to access a method defined on the class, and the () symbols are the method invocation operators.
-When calling a stateless method, you don't need to create a new instance of its class first.
-When calling a stateful method, you need to create an instance of the class, and access the method on the object.
-Use the new operator to create a new instance of a class.
-An instance of a class is called an object.
# Difference between Parameter and Argument 
'Parameter' refers to the variable that's being used inside the method. An 'Argument' is the value that's passed when the method is called.

--Example of Parameter: In the function Add(int a, int b), a and b are parameters. They act as placeholders for any values you want to add together.
--Example of Argument: If you call Add(5, 3), then 5 and 3 are arguments. These are the real values that get assigned to a and b when the function runs.

# Array Basics
Arrays can be used to store multiple values of the same type in a single variable. The values stored in an array are generally related. 
For example, a list of student names could be stored in a string array named students.
"An array is a collection of individual data elements accessible through a single variable name. You use a zero-based numeric index to access each element of an array. 
Arrays allow you to create a collection of data values that shares a common purpose or characteristics under a single variable name for easier processing."
