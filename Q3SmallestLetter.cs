using System;

namespace BinarySearchPractice_Video15
{
    public class Q3SmallestLetter
    {

        public void Q3SmallestLetterGreaterThanTarget()
        {
            char[] inp = new char[] { };
            char[] letters = new char[] { 'd', 'e', 'h', 'k', 'p', 'w', 'x', 'z' };
            Console.WriteLine("[{0}]", string.Join(", ", letters));
            char target;
            string cond = "";
            while (cond != "n")
            {
                Console.Write("Enter Input for question:");
                string input = Console.ReadLine();
                //int inp = Convert.ToInt32(input);
                inp = input.ToCharArray();
                target = inp[0];
                GetResult(letters, target);
                Console.Write("Wanna try again(y/n): ");
                cond = Console.ReadLine();
            }
        }

        private char GetResult(char[] letters, char target)
        {
            char result;
            int start = 0;
            int end = letters.Length - 1;
            while (start <= end)
            {
                int mid = start + (end - start) / 2;
                if (target < letters[mid])
                {
                    end = mid - 1;
                }
                else
                {
                    start = mid + 1;
                }
            }
            result = letters[start % letters.Length];
            Console.WriteLine("Smallest letter greater than {0} is {1}", target, result);

            return result;

        }
    }
}