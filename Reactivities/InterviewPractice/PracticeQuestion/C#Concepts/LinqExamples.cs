using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InterviewPractice.PracticeQuestion.C_Concepts
{
    public class LinqExamples
    {

        public static void Multiply2atOddNumber()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] arr1 = {1,3,9,4,0};
            var reuslt = arr.Select((value, index) => index % 2 == 1 ? value * 2 : value).ToArray();
            Console.WriteLine(string.Join(",", reuslt));
            //First and firstorDefault
            Console.WriteLine(arr.First());
            Console.WriteLine(arr1.FirstOrDefault());
            //Single and sigleorDefault
           // Console.WriteLine(arr1.Single());
            Console.WriteLine(string.Join(",",arr.Intersect(arr1)));

        }
      
    }
}
