namespace InterviewPractice.PracticeQuestion.Patterns
{
    public static class Pyramid
    {
        public static void InvertedHalfNumericPyramid()
        {
            Console.WriteLine("Please enter the number");
            int n = int.Parse(Console.ReadLine());

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n - row; col++)
                {
                    Console.Write((col + 1) + " ");
                }
                Console.WriteLine();

            }
            Console.ReadKey();
        }

        public static void NumericTranglePyramid()
        {
            //number of rows=4
            //row0= 0
            //row1=1 1
            //row2=2 2 2
            //row3=3 3 3
            //row4=4 4 4 4


            int n = 9;
            //int.Parse( Console.ReadLine());

            for (int row = 0; row <= n; row++)
            {

                for (int col = 0; col < row + 1; col++)
                {
                    Console.Write(row + " ");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
