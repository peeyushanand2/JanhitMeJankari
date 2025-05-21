using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.PracticeQuestion.C_Concepts
{
    public class Factorial
    {
        //5!=5*4*3*2*1=
        public static long  CalculateFactorial( int n) 
        {
            if (n < 0)
                throw new ArgumentException("negative not allowed");
            if (n == 0 || n == 1)
            { 
                return 1;
            }
            //   
            return n*CalculateFactorial(n-1); //4*3*2*1=24
        }

    }
}
