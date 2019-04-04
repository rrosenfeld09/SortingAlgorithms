//SELECTION SORT

using System;
class Program
{

    public static int[] SelectionSort(int[] arr)
    {
        int array_size = arr.Length;
        int[] array = arr;
        Console.WriteLine("The Array Before Selection Sort is: ");
        for (int i = 0; i < array_size; i++)
        {
            Console.WriteLine(array[i]);
        }
        int tmp, min_key;

        for (int j = 0; j < array_size - 1; j++)
        {
            min_key = j;

            for (int k = j + 1; k < array_size; k++)
            {
                if (array[k] < array[min_key])
                {
                    min_key = k;
                }
            }

            tmp = array[min_key];
            array[min_key] = array[j];
            array[j] = tmp;
        }

        Console.WriteLine("The Array After Selection Sort is: ");
        for (int i = 0; i < array_size; i++)
        {
            Console.WriteLine(array[i]);
        }
        Console.ReadLine();
        return array;
    
    }
    static void Main(string[] args)
    {
       SelectionSort(new int[]{5,6,7,8,1,0,7,8});

    }
}