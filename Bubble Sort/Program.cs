
/*
 * C# Program to Perform Bubble Sort
 */
using System;
class bubblesort
{

        public static int[] BubbleSort(int[] arr)
        {
             
            int t;
            Console.WriteLine("The Array is : ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        t = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = t;
                    }
                }
            }
            Console.WriteLine("The Sorted Array :");
            foreach (int aray in arr)                         
                Console.Write(aray + " ");
            Console.ReadLine();
            return arr;
        }
        
        static void Main(string[] args)
        {
            BubbleSort(new int[] {30, 20, 50, 40, 10 });
        }
    }