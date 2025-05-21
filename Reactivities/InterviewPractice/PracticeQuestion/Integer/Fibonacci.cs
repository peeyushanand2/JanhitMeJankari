using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.PracticeQuestion.Integer;

public class Fibonacci
{
    public static int PrintFabonaccNumberRecur(int n)
    {
        if (n <= 1)
            return n;
        return PrintFabonaccNumberRecur(n - 1) + PrintFabonaccNumberRecur(n - 2);
    }
    public static void PrintFabonaccNumber(int n)
    {

        int first = 0, second = 1, next;

        for (int i = 0; i < n; i++)
        {
            Console.Write(first + " ");
            next = first + second;
            first = second;
            second = next;
        }
    }
}

 
 
