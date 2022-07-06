using System;

namespace BinarySearchPractice_Video15
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[] { -6, -3, 0, 3, 5, 8, 12, 14, 15, 17, 24 };
            Console.WriteLine("[{0}]", string.Join(", ", arr1));
            Q1CeilingOfANumber q1 = new Q1CeilingOfANumber();
            string cond = "";
            while (cond!="n")
            {
                Console.Write("Enter Input for ceiling question:");
                string input = Console.ReadLine();
                int inp = Convert.ToInt32(input);
                int result = q1.GetCeilingOfNumber(arr1, inp);
                Console.WriteLine("Ceiling of the number {0} is {1}", input, result);
                Console.Write("Wanna try again(y/n): ");
                cond = Console.ReadLine();
            }



            Console.WriteLine("> Goodbye!");
        }
    }
}
