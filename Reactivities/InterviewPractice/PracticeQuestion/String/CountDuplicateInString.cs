namespace InterviewPractice.PracticeQuestion.String
{
    public class CountDuplicateInString
    {
        public void CountDuplicate(string input)
        {
            IDictionary<char, int> dup = new Dictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (dup.ContainsKey(input[i]))
                {

                    //  dup.TryGetValue(input[i], out int x);
                    // dup.Remove(input[i]);
                    // dup.Add(input[i], ++x);

                    //other way
                    dup[input[i]]++;
                }
                else
                {
                    // dup.Add(input[i], 1);
                    //other way
                    dup[input[i]] = 1;
                }
            }
            foreach (KeyValuePair<char, int> keyValuePair in dup)
            {
                Console.WriteLine($"{keyValuePair.Key} - {keyValuePair.Value}");
            }
        }

    }
}
