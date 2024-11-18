using InterviewPractice.PracticeQuestion.Integer;
using InterviewPractice.PracticeQuestion.LL;
using InterviewPractice.PracticeQuestion.Patterns;
using InterviewPractice.PracticeQuestion.QuickTest;
using InterviewPractice.PracticeQuestion.String;
#region LL

CustomLinkedList newLinkedList = new CustomLinkedList(4);
#endregion
#region Array

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
#endregion

#region String
//Count duplicate in string 
CountDuplicateInString d = new CountDuplicateInString();
d.CountDuplicate("Proograaam is test");

//Remove duplicate from string
RemoveDuplicateFromString rem = new RemoveDuplicateFromString();
rem.RemoveDuplicate("Proograaam is test");
#endregion


Console.ReadKey();
