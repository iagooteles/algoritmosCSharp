using System;

namespace Algoritmos
{
    public static class BubbleSort
    {
        public static void Execute()
        {
            int[] arr = { 64, 34, 25, 12, 22, 11, 90 };
            Console.WriteLine("Array original:");
            PrintArray(arr);

            Sort(arr);

            Console.WriteLine("\nArray ordenado:");
            PrintArray(arr);
        }

        // método que aplica o bubble sort
        private static void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        private static void PrintArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
