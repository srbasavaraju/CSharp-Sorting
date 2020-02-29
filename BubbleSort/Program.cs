using System;
using System.Collections.Generic;

namespace BubbleSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            Console.WriteLine("Bubble Sort");
            Console.Write("-----------------------------------------\n");
            Console.WriteLine("Please enter the array of integers ");

            string[] stringArr = Console.ReadLine().Split(' ');

            foreach (string str in stringArr)
            {
                arr.Add(Convert.ToInt32(str));
            }

            BubbleSort bubbleSort = new BubbleSort();
            int[] sortedArr = bubbleSort.Sort(arr.ToArray());

            Console.WriteLine("Sorted Array");
            foreach (int item in sortedArr)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}

