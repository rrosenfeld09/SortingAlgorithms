/*
 *  C# Program to Implement Quick Sort
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
 
namespace sortQuickAlgorithm
{
    class quickSortAlgorithm
    {
 
        private static int[] array;
 
        public static void QuickSortAlgorithm(int[] intArr)
        {
            array = intArr;
            sort(0, intArr.Length - 1);
            foreach( int element in intArr)
            {
                Console.WriteLine(element);
            }

            
        }
 
        public static void sort(int left, int right)
        {
            int pivot, leftend, rightend;
 
            leftend = left;
            rightend = right;
            pivot = array[left];
 
            while (left < right) { while ((array[right] >= pivot) && (left < right))
                {
                    right--;
                }
 
                if (left != right)
                {
                    array[left] = array[right];
                    left++;
                }
 
                while ((array[left] >= pivot) && (left < right))
                {
                    left++;
                }
 
                if (left != right)
                {
                    array[right] = array[left];
                    right--;
                }
            }
 
            array[left] = pivot;
            pivot = left;
            left = leftend;
            right = rightend;
 
            if (left < pivot) { sort(left, pivot - 1); } if (right > pivot)
            {
                sort(pivot + 1, right);
            }
        }
 
        public static void Main()
        {

            QuickSortAlgorithm(new int[]{1,4,2,6,4,2,3333});    

        }
    }
}