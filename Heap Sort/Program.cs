
/*
 * C# Program to Heap Sort
 */
using System;
class heapsort
{
    public static int[] r;
    public static void hsort(int[] arr)
    {
        r = arr;
        for (int i = 5; i >= 0; i--)
        {
            adjust(i, arr.Length);
        }
        for (int i = 8; i >= 0; i--)
        {
            int t = r[i + 1];
            r[i + 1] = r[0];
            r[0] = t;
            adjust(0, i);
        }
    }
    private static void adjust(int i, int n)
    {
        
        try
        {
            int t = r[i];
            int j = 2 * i;
            while (j <= n)
            {
                if (j < n && r[j] < r[j + 1])
                    j++;
                if (t >=r[j])
                    break;
                r[j / 2] = r[j];
                j *= 2;
            }
            r[j / 2] = t;
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Array Out of Bounds ", e);
        }
    }

    public static void Main()
    {
        
        hsort(new int[]{5,6,3,5,6,7});
    }
}