using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.PracticeQuestion.C_Concepts
{
    public interface I1
    {
        void Add();
    }
    interface I2
    {
        void Add();
    }

    public class A : I1, I2
    {
        void I1.Add()
        {
            Console.WriteLine("Add I1 method in class A");
        }
        void I2.Add()
        {
            Console.WriteLine("Add I2 method in class A");
        }
    }
}
