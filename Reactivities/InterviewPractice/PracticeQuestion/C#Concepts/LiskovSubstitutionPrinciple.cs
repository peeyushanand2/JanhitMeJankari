namespace InterviewPractice.PracticeQuestion.QuickTest
{

    public class Apples
    {
        public virtual void Color()
        {
            Console.WriteLine("Red");
        }
    }
    public class Oranges : Apples
    {
        public override void Color()
        {
            Console.WriteLine("Orange");
        }
    }

    //LSP Implimented
    public abstract class Fruit
    {
        public abstract void color();

    }
    public class Apple : Fruit
    {
        public override void color()
        {
            Console.WriteLine("Apple");
        }

    }
    public class Orange : Fruit
    {
        public override void color()
        {
            Console.WriteLine("orange");
        }

    }

}
