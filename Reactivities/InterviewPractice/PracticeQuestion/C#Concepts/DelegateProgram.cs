using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.PracticeQuestion.C_Concepts
{
    public delegate void MyDelegate(string message);
    public class DelegateProgram
    {
        public static void DisplayMessage(string message)
        {
            Console.WriteLine(message);
        }
        public static void DisplayMessage2(string message)
        {
            Console.WriteLine(message);
        }
      
        //Built-in Generic Delegates
        //1. Action Delegate: Represent a method that take zero or more input parameter and does not return a value. can take up to 16 parameter
        //2. Func Delegate: Represent a method that take sero or more input parameter and return a value., Last para is the return type,
        //3. Predicate Delegate: Represent a method that take one input parameter and return a bool. Commonaly use for filtering or coditional checks
        public static void CheckBuilinDelegates()
        {
            //Action
            Action<string,string> actions = (message,meesage1) => Console.WriteLine(message+meesage1);
            actions("hello","Peeyush");
            
            //Func 
            Func<int, int, int> add = (x,y)=>x+y;
            int s= add(4,5);
            Console.WriteLine( "func delegate:{0}",s);
       
            //PredicateIQueryable
            Predicate<int> predicate = s=>s%2==0;
            bool res= predicate(2);
            Console.WriteLine("Predicate:{0}",res);
           
           // Anonymous Methods
            var del = delegate (string message)
            {
                Console.WriteLine( message);
            };
            del("this is anonymous delegate");
        }
        public static void FindEvenNumberInIntArray()
        {
            int[] arr = { 2,4,6,6,79,5,8,9};
        Predicate<int> IsEven=d=>d%2==0;
        List<int> res=    arr.ToList().FindAll(IsEven);
          //  foreach (int i in res)
            Console.WriteLine("even number are:{0}", string.Join(",", res.ToArray()));
        }
    }
}
