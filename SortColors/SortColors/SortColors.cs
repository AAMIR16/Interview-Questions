using System;

namespace SortColors
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int[] arr = { 0, 2, 2, 1, 0, 1, 1 };
            sortColors(arr);

            foreach (var item in arr)
            {
                Console.WriteLine(item);
            }
        }
        public static void sortColors(int[] nums)
        {
            int lo = 0, hi = nums.Length - 1, i = 0;

            while (i <= hi)
            {
                if (nums[i] == 0) swap(nums, lo++, i++);
                else if (nums[i] == 2) swap(nums, i, hi--);
                else if (nums[i] == 1) i++;
            }
        }
        static void swap(int[] nums, int i, int j)
        {
            int t = nums[i];
            nums[i] = nums[j];
            nums[j] = t;
        }

    }
}
