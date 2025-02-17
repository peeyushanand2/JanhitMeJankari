using InterviewPractice.PracticeQuestion.C_Concepts;
using InterviewPractice.PracticeQuestion.Integer;
using InterviewPractice.PracticeQuestion.LL;
using InterviewPractice.PracticeQuestion.Patterns;
using InterviewPractice.PracticeQuestion.QuickTest;
using InterviewPractice.PracticeQuestion.String;
#region LL
LinkedList myLinkedList = new LinkedList(4);
//Print LL
myLinkedList.Append(2);
myLinkedList.PrintLL();

#endregion

#region Array

#endregion

#region C#Concepts
//Without LSP
Oranges orange = new Oranges();
orange.Color();
//even apple reference variable hoding the child object
//and its vilation of LSPP
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
CountDuplicateInString.CountDuplicate("Proograaam is test");

//Remove duplicate from string
RemoveDuplicateFromString.RemoveDuplicate("Proograaam is test");

//Calculator<int> calculator = new Calculator<int>();
//Console.WriteLine(calculator.Max(2, 5));



StringPalindrom<string> aaa=new StringPalindrom<string>();
string result = aaa.IsPalindrom("JAHAZ") == true ? "This is palindrom" : "this is not a palindrom";
Console.WriteLine(result);
IntegerPalindrom integerPalindrom = new IntegerPalindrom();

string res = integerPalindrom.IsPalindrom(121)== true ? "This iteger is palindrom" : "this is not a palindrom";
Console.WriteLine(res);
#endregion

Console.ReadKey();
