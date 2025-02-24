using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewPractice.PracticeQuestion.ArrayPractice
{
    internal class ArrayPrograms
    {
        public static void Convert2DarrayTo1DarrayPractice()
        {
            //converting 2d array to 1d array  
            //Solution1
            int[,] ints2 = { { 1, 2, 3 }, { 2, 3, 5 } };

            int rr = ints2.GetLength(0);
            int cc = ints2.GetLength(1);
            int[] newarray = new int[rr * cc];
            int index = 0;
            for (int i = 0; i < rr; i++)
            {
                for (int j = 0; j < cc; j++)
                {
                    newarray[index++] = ints2[i, j];
                }
            }
            Console.WriteLine("Convert2DarrayTo1DarrayPractice Solution1: {0}", string.Join(", ", newarray));

            //  //Solution2
            int[] oneArray = new int[ints2.Length];
            int indexs = 0;
            foreach (var i in ints2)
            {
                oneArray[indexs++] = i;
            }
            Console.WriteLine("Convert2DarrayTo1DarrayPractice Solution2: {0} ", string.Join(", ", oneArray));
        }
        public static void ReverseArray()
        {
            int[] input = { 1, 2, 3, 4, 5 };
            int[] res = new int[input.Length];
            // Array.Reverse(input);
            // Console.WriteLine(string.Join(",",input));
            int indx = 0;
            for (int i = input.Length; i > 0; i--)
            {
                res[indx++] = input[i - 1];
            }
            Console.WriteLine("ReverseArray: {0}", string.Join(",", res));
        }
        public static void Find_the_Maximum_and_Minimum_in_Array()
        {
            int[] arr = { 3, 5, 1, 8, -2, 7, 10, 4 };
            // Array.Sort(arr);
            //  Console.WriteLine("Min:{0} Max:{1}", arr[0],arr[(arr.Length)-1]);

            //Solution2
            int min = arr[0];
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
                if (arr[i] < min)
                {
                    min = arr[i];
                }
            }
            Console.WriteLine("Min:{0} Max:{1}", min, max);

        }
        public static void Finding_SecondLargestElement_IN_Array()
        {
            int[] arr = { 3, 5, 1, 8, -2, 7, 10, 4 };

            int LargestElement = arr[0];
            int secondLargest = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > LargestElement)
                {
                    secondLargest = LargestElement;
                    LargestElement = arr[i];
                }
            }
            Console.WriteLine("second largest in array :{0}", secondLargest);

        }
        public static void Remove_Duplicates_FROM_Array()
        {
            int[] arr = { 3, 5, 1, 5, -2, 7, 10, -2 };

            int[] res = new int[arr.Length];
            int index = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (!res.Contains(arr[i]))
                {
                    res[index++] = arr[i];
                }
            }
            Console.WriteLine(string.Join(",", res.ToArray()));
        }
        public static void BuySell_Stock_CalculateMaxProfit()
        {
            int[] prices = { 3, 5, 1, 8,7, 10, 4 };
            // Solution1 : brute force
            int maxProfit = 0;
            for (int i = 0; i < prices.Length-1; i++)
            {
                for (int j = i + 1; j < prices.Length; j++)
                { 
                if ((prices[j] - prices[i]) > maxProfit)
                    {
                        maxProfit= prices[j] - prices[i];
                    }

                }
            }
            Console.WriteLine("BuySell Solution1 Get MaxPRofit:" + maxProfit);

            // Solution2 :
            int minprice = int.MaxValue;
            int maxPrft = 0;
            for (int i = 0; i < prices.Length - 1; i++)
            {
                if (prices[i] < minprice)
                { 
                minprice= prices[i];
                }
                else if (prices[i] - minprice > maxPrft)
                {
                    maxPrft = prices[i]-minprice;
                }

            }
            Console.WriteLine("BuySell Solution2 Get MaxPRofit:" + maxProfit);
        }
    }
}
