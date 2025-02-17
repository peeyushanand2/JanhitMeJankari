using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.PracticeQuestion.C_Concepts
{
    internal class MultipleTask
    {
        public void Mehtod1()
        {
            Console.WriteLine("Mehtod1 started");
            Thread.Sleep(5000);
            Console.WriteLine("Mehtod1 end");
        }
        public void Mehtod2()
        {
            Console.WriteLine("Mehtod2 started");
            Thread.Sleep(10000);
            Console.WriteLine("Mehtod2 end");
        }
        public void Mehtod3()
        {
            Console.WriteLine("Mehtod3 started");
            
            Console.WriteLine("Mehtod3 end");
        }
    }
}
