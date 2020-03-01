using System;
using System.Collections.Generic;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> arr = new List<int>();
            Console.WriteLine("Quick Sort");
            Console.Write("-----------------------------------------\n");
            Console.WriteLine("Please enter the array of integers ");

            string[] stringArr = Console.ReadLine().Split(' ');

            foreach (string str in stringArr)
            {
                arr.Add(Convert.ToInt32(str));
            }

            QuickSort quickSort = new QuickSort();
            int[] sortedArr = quickSort.Sort(arr.ToArray(), 0, arr.Count-1);

            Console.WriteLine("Sorted Array");
            foreach (int item in sortedArr)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
