using System;
using System.Collections.Generic;

namespace scrap
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var nums = new int[] { 0, 1, 2, 4, 6, 7 };
            var summary = new List<string>();

            //var start = input[0];
            //var end = input[0];

            var len = nums.Length;

            //for (int i = 0; i< input.Length; i++)
            //{
            //    if (input.Length-1 != i)
            //    {
            //        if (input[i] + 1 == input[i + 1])
            //        { }
            //        else
            //        {
            //            end = input[i];
            //            if (end == start)
            //                summary.Add($"{input[i]}".ToString());
            //            else
            //                summary.Add(start.ToString() + "->" + end.ToString());


            //            start = input[i + 1];

            //        }
            //    }
            //}
            //foreach (var item in summary)
            //    Console.Write(item + " ");

            var startValue = nums[0];
            //var endValue = nums[0];

            for (int i = 0; i < len; i++)
            {
                if(i == len - 1 || nums[i]+1 != nums[i+1])
                {
                    if (nums[i] != startValue)
                    {
                        summary.Add(startValue + "->" + nums[i]);
                    }
                    else
                    {
                        summary.Add(startValue.ToString());
                    }
                    if (i != len-1)
                    {
                        startValue = nums[i + 1];
                    }
                       
                }
              
            }
            //return summary;
            foreach (var item in summary)
                Console.Write(item + " ");

        }
    }
}
