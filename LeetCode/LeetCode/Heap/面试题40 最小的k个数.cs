using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LeetCode
{
    public partial class Heap
    {

        public static int[] GetLeastNumbers(int[] arr, int k)
        {

            return Sort(arr, 0, arr.Length - 1, k);
        }

        private static int[] Sort(int[] arr, int l, int r, int k)
        {
            if (l > r) return new int[0];
            int index = Partition(arr, l, r);
            if (index == k - 1) return arr.Take(k).ToArray();
            return index > k ? Sort(arr, l, index - 1, k) : Sort(arr, index + 1, r, k);
        }

        private static int Partition(int[] arr, int l, int r)
        {
            int key = arr[l];
            while (r > l)
            {
                while (r > l && arr[r] >= key)
                    r--;
                arr[l] = arr[r];
                while (r > l && arr[l] < key)
                    l++;
                arr[r] = arr[l];
            }

            arr[l] = key;
            foreach (var i in arr)
            {
                Console.Write($"{i}\t");
            }
            Console.WriteLine();
            return r;
        }

        public static int[] GetLeastNumbers2(int[] arr, int k)
        {
            System.Array.Sort(arr);
            return arr.Take(k).ToArray();
        }


        public static int[] GetLeastNumbers1(int[] arr, int k)
        {
            int[] result = new int[k];
            for (int i = 0; i < k; i++)
            {
                for (int j = i+1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        var temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }

                result[i] = arr[i];
            }

            return result;
        }
    }
}
