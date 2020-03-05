using System;

namespace sorting_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 4, 1, 6, 10, -3 };
            sort(nums);
            print(nums);

            
        }
        static void sort(int[] arr)
        {
            for (int i = 0; i < arr.Length-1; i++)
            {
                for (int j = 0; j < arr.Length-1-i; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int num = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = num;
                    }
                }
            }
        }
        static void print(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.WriteLine(item+" ");
            }
        }
    }
}
