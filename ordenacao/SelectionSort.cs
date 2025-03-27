using System;

namespace Algoritmos
{
    public static class SelectionSort
    {
        public static void Execute()
        {
            int[] arr = {64, 12, 205, 12, 260, 1, 150};
            Console.WriteLine("Array original: ");
            PrintArray(arr);

            Sort(arr);
            
            Console.WriteLine("Array Ordenado com Selection sort: ");
            PrintArray(arr);
        }

        private static void Sort(int[] arr) 
        {
            int n = arr.Length;
            for (int i = 0; i < n; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[j] < arr[minIndex])
                    {
                        minIndex = j;
                    }
                }
                int temp = arr[minIndex];
                arr[minIndex] = arr[i];
                arr[i] = temp;
            }
        }
    
        private static void PrintArray(int[] arr)
        {
            foreach(var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}