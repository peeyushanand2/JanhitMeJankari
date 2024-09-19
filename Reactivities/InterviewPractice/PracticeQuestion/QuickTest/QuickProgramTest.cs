namespace InterviewPractice.PracticeQuestion.QuickTest
{
    public class QuickProgramTest
    {
    }

    public class BaseClass
    {
        int ab = 0;

        public void Method()
        {

            Console.WriteLine($"{ab} in base class ");
        }
    }
    public class ClildClass : BaseClass
    {
        int ab = 0;

        public new void Method()
        {

            Console.WriteLine($"{ab} in child class ");
        }
    }
    public interface ITest
    {
        public void method();
        public void method2();
    }
}
