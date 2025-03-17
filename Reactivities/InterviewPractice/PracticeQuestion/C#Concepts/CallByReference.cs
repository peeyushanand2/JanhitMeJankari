using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.PracticeQuestion.C_Concepts
{

    internal class CallByValue
    {

        public CallByValue()
        {
                
        }
        public CallByValue(CallByValue callByValue)
        {
                
        }
        public static void Increment(int num)
        {
            num++; // This change will not affect the original variable
            Console.WriteLine($"Inside Method: num = {num}");
        }

    }
    internal class CallByReference
    {
        public static void Increment(ref int num)
        {
            num++; // This change will not affect the original variable
            Console.WriteLine($"Inside Method: num = {num}");
        }

    }
}
