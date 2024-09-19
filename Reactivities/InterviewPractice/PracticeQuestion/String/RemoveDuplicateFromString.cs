namespace InterviewPractice.PracticeQuestion.String
{
    public class RemoveDuplicateFromString
    {
        public void RemoveDuplicate(string input)
        {
            string result = string.Empty;

            for (int i = 0; i < input.Length; i++)
            {
                if (!result.Contains(input[i]))
                {
                    result += input[i];
                }
            }
            Console.WriteLine($"Actual string is {input} and removed string is {result}");
        }
    }
}
