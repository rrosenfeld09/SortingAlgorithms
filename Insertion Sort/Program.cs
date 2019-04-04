/*
 * C# Program to Perform Insertion Sort
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
namespace ConsoleApplication1
{
    class Program
    {

        static void insertsort(int[] data)
        {
            int n = data.Length;
            Console.WriteLine("The Array is :");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(data[i]);
            }

            for (int i = 1; i < n; i++)
            {
                int item = data[i];
                int ins = 0;
                for (int j = i - 1; j >= 0 && ins != 1; )
                {
                    if (item < data[j])
                    {
                        data[j + 1] = data[j];
                        j--;
                        data[j + 1] = item;
                    }
                    else ins = 1;
                }
            }
            Console.WriteLine("The Sorted Array is :");
            for (int i = 0; i < 5; i++)
                Console.WriteLine(data[i]); 
        }
        static void Main(string[] args)
        {
            int[] arr = new int[5] { 83, 12, 3, 34, 60 };

            insertsort(arr);
        }        
    }
}