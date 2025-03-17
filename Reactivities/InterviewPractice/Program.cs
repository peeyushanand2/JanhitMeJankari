using InterviewPractice.PracticeQuestion.ArrayPractice;
using InterviewPractice.PracticeQuestion.C_Concepts;
using InterviewPractice.PracticeQuestion.Integer;
using InterviewPractice.PracticeQuestion.LL;
using InterviewPractice.PracticeQuestion.Patterns;
using InterviewPractice.PracticeQuestion.QuickTest;
using InterviewPractice.PracticeQuestion.String;
using static System.Runtime.InteropServices.JavaScript.JSType;
#region Array
ArrayPrograms.Convert2DarrayTo1DarrayPractice();
ArrayPrograms.ReverseArray();
ArrayPrograms.Find_the_Maximum_and_Minimum_in_Array();
ArrayPrograms.Finding_SecondLargestElement_IN_Array();
ArrayPrograms.Remove_Duplicates_FROM_Array();
ArrayPrograms.BuySell_Stock_CalculateMaxProfit();
#endregion

MyDelegate del1=DelegateProgram.DisplayMessage;
MyDelegate del2=DelegateProgram.DisplayMessage2;
MyDelegate mainDel = del1 + del2;//Multicast delegate
mainDel("hello multicast deligate");
DelegateProgram.CheckBuilinDelegates();
DelegateProgram.FindEvenNumberInIntArray();

//Multiple task execution
MultipleTask multipleTask = new MultipleTask();
var task1=Task.Run(()=>multipleTask.Mehtod1());
var task2=Task.Run(()=>multipleTask.Mehtod2());
await task1;
multipleTask.Mehtod3();
await task2;
//task1.ContinueWith(_ => multipleTask.Mehtod3());
//await Task.WhenAll(task1, task2);
#region LL
LinkedList myLinkedList = new LinkedList(4);
//Print LL
myLinkedList.Append(2);
myLinkedList.PrintLL();

#endregion

#region C#Concepts

//Call by Value
int number = 10;
Console.WriteLine($"Before Method Call: number = {number}");
CallByValue.Increment(number);
Console.WriteLine($"After Method Call: number = {number}");

//Call by Reference
int number2 = 10;
Console.WriteLine($"Before Method Call: number = {number2}");
CallByReference.Increment(ref number2);
Console.WriteLine($"After Method Call: number = {number2}");


//Without LSP
Oranges orange = new Oranges();
orange.Color();
//even apple reference variable hoding the child object
//and its voilation of LSPP
Apples apples = new Oranges();
apples.Color();

// LSP
//here fruilt base class object reference variable can be replaced with Orange class 
//and Apple class
//this is the LSP
Fruit obj = new Orange();
obj.color();
obj = new Apple();
obj.color();

//quick prograam
ClildClass ch = new ClildClass();
ch.Method();
//how can we call base class method with child class object 
BaseClass bs = new ClildClass();
bs.Method();

A a = new A();
I1 i1 = a;
i1.Add();

I2 i2 = a;
i2.Add();


#endregion

#region Integer
//reverse integer
int input = 123;
int x = ReverseInteger.Reverse(input);
Console.WriteLine($"Reverse of {input} is {x}");

//reverse integer using Stack;
int inputstack = -123;
int xStack = ReverseInteger.ReverseUsingStack(inputstack);
Console.WriteLine($"Reverse of {input} is {xStack}");
#endregion

#region Patterns
// Pyramid.InvertedHalfNumericPyramid();

Pyramid.NumericTranglePyramid();
#endregion

#region String
//Count duplicate in string 
CountDuplicateInString.CountDuplicate();

//Remove duplicate from string
RemoveDuplicateFromString.RemoveDuplicate();

//Calculator<int> calculator = new Calculator<int>();
//Console.WriteLine(calculator.Max(2, 5));
 
StringPalindrom.IsStringPalindrom();
StringPalindrom.IsIntegerPalindrom();
 
#endregion

Console.ReadKey();
