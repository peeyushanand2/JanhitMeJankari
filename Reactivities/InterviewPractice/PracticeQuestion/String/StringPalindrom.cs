using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.PracticeQuestion.String
{
    internal class StringPalindrom<T>
    {
        //writing string palindrom JAHAJ
      
       
        public bool IsPalindrom(string input)
        { 
            StringBuilder output = new StringBuilder();
            for (int i = input.Length; i > 0; i--)
            { 
            output.Append(input[i-1]);
            }

            if(input.Equals(output.ToString()))return true;
            return false;
        }
    }

    internal class IntegerPalindrom
    {
        public bool IsPalindrom(int input)
        {
            int res = 0;
            int oldInput = input;
            //121
            while (input > 0)
            {
                int b = input % 10;//1,2,1
                res = res * 10 + b;//1,12,120+1=121
                input = input / 10;//121/10=12,12/10,1
            }
            if(res.Equals(oldInput))
            return true;
            return false;
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
