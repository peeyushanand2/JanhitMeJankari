using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace InterviewPractice.PracticeQuestion.C_Concepts
{
    public class LinqExamples
    {

        public static void Multiply2atOddNumber()
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int[] arr1 = {1,3,9,4,0};
            var reuslt = arr.Select((value, index) => index % 2 == 1 ? value * 2 : value).ToArray();
            Console.WriteLine(string.Join(",", reuslt));
            //First and firstorDefault
            Console.WriteLine(arr.First());
            Console.WriteLine(arr1.FirstOrDefault());
            //Single and sigleorDefault
           // Console.WriteLine(arr1.Single());
            Console.WriteLine(string.Join(",",arr.Intersect(arr1)));

        }
        public static void FindElemetthatNotRepeted()
        {
            int[] arr = { 1, 2, 3,2, 3,1, 7, 8,7 };
             Array.Sort(arr);
            //suign linq
            var res = from item in arr
                    .GroupBy(x => x)
                    .Where(g => g.Count() == 1)
                        select new {
                        key= item.Key,
                        };
            Console.WriteLine(string.Join(",", res.Single()));
         
            var result = arr.GroupBy(x => x)
                            .Where(g => g.Count() == 1)
                            .Select(g => g.Key)
                            .Single();
            Console.WriteLine(string.Join(",", result));

            //sql query
            // select * from table where id not in (select id from table group by id having count(id)>1)

            Dictionary<int, int> dict = new Dictionary<int, int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (dict.ContainsKey(arr[i]))
                {
                    dict[arr[i]]++;
                }
                else
                {
                    dict[arr[i]] = 1;
                }
            }
            foreach (var item in dict)
            {
                if (item.Value == 1)
                {
                    Console.WriteLine(item.Key);
                }
            }
        }
        public static void FindKthElemetInUnSortedArrar()
        {
            int[] arr = { 1, 2, 3, 2, 3, 1, 7, 8, 7 };
            int k = 3;
            //using linq
            var result = arr.OrderBy(zx => zx).Distinct();
                //.Skip(k - 1).FirstOrDefault();
            //using sql
            Array.Sort(arr);
           
            int n = arr[k - 1];
            Console.WriteLine(n);

        }

    }
}
