using System;

namespace Algoritmos
{
    public static class BuscaBinaria
    {
        public static void Execute()
        {
            int[] arr = [3, 8, 15, 23, 42, 56, 72, 91];
            int alvo = 42;

            Console.WriteLine("Array (ordenado):");
            PrintArray(arr);

            Console.WriteLine($"\nBuscando pelo valor {alvo} usando busca binária...");

            int resultado = BinarySearch(arr, alvo);

            if (resultado != -1)
                Console.WriteLine($"Elemento encontrado na posição {resultado}.");
            else
                Console.WriteLine("Elemento não encontrado.");
        }

        private static int BinarySearch(int[] arr, int alvo)
        {
            int inicio = 0;
            int fim = arr.Length - 1;

            while (inicio <= fim)
            {
                int meio = inicio + (fim - inicio) / 2;

                if (arr[meio] == alvo)
                    return meio;

                if (arr[meio] < alvo)
                    inicio = meio + 1;
                else
                    fim = meio - 1;
            }

            return -1; // não encontrado
        }

        private static void PrintArray(int[] arr)
        {
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}
