namespace InterviewPractice.PracticeQuestion.Integer
{
    public static class ReverseInteger
    {
        public static int Reverse(int x)//123
        {
            //check if its negative number
            bool IsNegative = x < 0;
            if (IsNegative)
            {
                x = -x;
            }
            int newNumber = 0;
            while (x != 0)
            {
                int lastDigit = x % 10;
                newNumber = newNumber * 10 + lastDigit;
                x = x / 10;

            }
            return IsNegative ? -newNumber : newNumber;

        }
        public static int ReverseUsingStack(int x)
        {
            bool IsNegative = x < 0;
            if (IsNegative) { x = -x; }


            Stack<int> stack = new Stack<int>();
            while (x != 0)
            {
                int lastDigit = x % 10;
                stack.Push(lastDigit);
                x = x / 10;

            }
            int newNumber = 0;
            int multiplier = 1;
            while (stack.Count > 0)
            {
                newNumber = newNumber + stack.Pop() * multiplier;
                multiplier *= 10;
            }

            return IsNegative ? -newNumber : newNumber;
        }
    }
}
