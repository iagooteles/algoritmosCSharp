using System;

namespace Algoritmos
{
    public static class InsertionSort
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

        // Método que aplica o Insertion Sort
        private static void Sort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 1; i < n; i++)
            {
                int chave = arr[i];
                int j = i - 1;

                // Move os elementos maiores que a chave para a frente
                while (j >= 0 && arr[j] > chave)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }
                arr[j + 1] = chave;
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
