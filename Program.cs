using System;

namespace BinarySearchPractice_Video15
{
    class Program
    {
        static void Main(string[] args)
        {
            //int[] arr1 = new int[] { -6, -3, 0, 3, 5, 8, 12, 14, 15, 17, 24 };
            //Console.WriteLine("[{0}]", string.Join(", ", arr1));
            
            Q1CeilingOfANumber q1 = new Q1CeilingOfANumber();
            Q2FloorOfANumber q2 = new Q2FloorOfANumber();
            Q3SmallestLetter q3 = new Q3SmallestLetter();
            //q3.Q3SmallestLetterGreaterThanTarget();
            Q4FirstLastPosInSortedArr  q4= new Q4FirstLastPosInSortedArr();
            q4.FirstLastPositionSortedArray();
            //string cond = "";
            //while (cond != "n")
            //{
            //    Console.Write("Enter Input for floor question:");
            //    string input = Console.ReadLine();
            //    int inp = Convert.ToInt32(input);
            //    int result = q2.GetFloorOfNumber(arr1, inp);
            //    Console.WriteLine("Floor of the number {0} is {1}", input, result);
            //    Console.Write("Wanna try again(y/n): ");
            //    cond = Console.ReadLine();
            //}




            Console.WriteLine("> Goodbye!");
        }
    }
}
