using System;

namespace BinarySearchPractice_Video15
{
    public class Q4FirstLastPosInSortedArr
    {
        public void FirstLastPositionSortedArray()
        {
            int[] arr1 = new int[] { -6, -6, -6, -6, -6, -3, -1, 0, 3, 5, 5, 5, 7, 8, 12, 12, 12, 12, 12, 14, 15 };
            Console.WriteLine("[{0}]", string.Join(", ", arr1));
            int target;
            string cond = "";
            while (cond != "n")
            {
                Console.Write("Enter Input for question:");
                string input = Console.ReadLine();
                int inp = Convert.ToInt32(input);
                target = inp;
                GetResult(arr1, target);
                Console.Write("Wanna try again(y/n): ");
                cond = Console.ReadLine();
            }
        }

        private void GetResult(int[] arr1, int target)
        {
            int[] result = new int[] { -1, -1 };
            int start = search(arr1, target, findStartIndex: true);
            int end=search(arr1, target, findStartIndex: false);
            
            result[0] = start;
            result[1] = end;

            Console.WriteLine("Result is: [{0}]", string.Join(", ", result));
        }

        private int search(int[] arr1, int target, bool findStartIndex)
        {
            int ans = -1;
            int start = 0;
            int end = arr1.Length - 1;

            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (arr1[mid] < target)
                {
                    start = mid + 1;
                }
                else if (arr1[mid] > target)
                {
                    end = mid - 1;
                }
                else
                {
                    ans =  mid;
                    if (findStartIndex == true)
                    {
                        end = mid - 1;
                    }
                    else
                    {
                        start = mid + 1;
                    }
                }
            }
            return ans;
        }
    }
}