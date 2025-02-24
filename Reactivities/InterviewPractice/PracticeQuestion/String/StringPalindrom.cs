using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.PracticeQuestion.String
{
    internal class StringPalindrom
    {
         
        public static void IsStringPalindrom()
        {
            string input = "JAHAZ";
            StringBuilder output = new StringBuilder();
            for (int i = input.Length; i > 0; i--)
            { 
            output.Append(input[i-1]);
            }
            
            if(input.Equals(output.ToString())) 
                Console.WriteLine("This is palindrom");
            Console.WriteLine("this is not a palindrom");
        }
        public static void IsIntegerPalindrom()
        {
            int input = 121;
            int res = 0;
            int oldInput = input;
            //121
            while (input > 0)
            {
                int b = input % 10;//1,2,1
                res = res * 10 + b;//1,12,120+1=121
                input = input / 10;//121/10=12,12/10,1
            }
            if (res.Equals(oldInput))
                Console.WriteLine("This is palindrom");
            Console.WriteLine("this is not a palindrom");
        }
    }
 
    public class Calculator<T> where T : IComparable<T>
    {
        public T Max(T a,T b)
        {
            return a.CompareTo(b) > 0 ? a : b ;

        }
    }

    }
