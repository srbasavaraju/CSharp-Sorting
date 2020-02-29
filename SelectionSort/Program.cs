using System;
using System.Collections.Generic;

namespace SelectionSort
{
    class Program
    {
        static void Main(string[] args)
        {

            List<int> arr = new List<int>();
            Console.WriteLine("Selection Sort");
            Console.Write("-----------------------------------------\n");
            Console.WriteLine("Please enter the array of integers ");

            string[] stringArr = Console.ReadLine().Split(' ');

            foreach (string str in stringArr)
            {
                arr.Add(Convert.ToInt32(str));
            }

            SelectionSort selectionSort = new SelectionSort();
            int[] sortedArr = selectionSort.Sort(arr.ToArray());

            Console.WriteLine("Sorted Array");
            foreach (int item in sortedArr)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }
    }
}
