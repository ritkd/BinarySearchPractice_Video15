using System;

namespace BinarySearchPractice_Video15
{
    /// <summary>
    /// Ceiling of a number means 
    /// to find the smallest number 
    /// greater than or equal to the 
    /// target
    /// </summary>
    internal class Q1CeilingOfANumber
    {
        internal int GetCeilingOfNumber(int[] arr1, int target)
        {
            int result = 0;           
            int start = 0;
            int end = arr1.Length-1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2; // in case the start + end exceeds range of int datatype
                if (target < arr1[mid]) 
                { 
                    end = mid - 1;
                }
                else if (target>arr1[mid])
                {
                    start = mid + 1;
                }
                else
                {
                    return arr1[mid];
                }
            }

            string cond = "";
            while (cond != "n")
            {
                Console.Write("Enter Input for ceiling question:");
                string input = Console.ReadLine();
                int inp = Convert.ToInt32(input);
                int res = GetCeilingOfNumber(arr1, inp);
                Console.WriteLine("Ceiling of the number {0} is {1}", input, res);
                Console.Write("Wanna try again(y/n): ");
                cond = Console.ReadLine();
            }

            return arr1[start];
        }
    }
}