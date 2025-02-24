using System.Text;

namespace InterviewPractice.PracticeQuestion.String
{
    public static class RemoveDuplicateFromString
    {
        public static void RemoveDuplicate()
        {
            string input = "Proograaam is test";
            StringBuilder result=new();

            for (int i = 0; i < input.Length; i++)
            {
                if (!result.ToString().Contains(input[i]))
                {
                    result.Append(input[i]);
                }
            }
            Console.WriteLine($"Actual string is {input} and removed string is {result}");
        }
    }
}
