using System;

namespace Algoritmos
{
    public static class BuscaLinear
    {
        public static void Execute()
        {
            int[] numeros = { 1, 5, 30, 17, 9, 13, 70, 90, 111, 123, 406, 490, 9000, 550, 398776, 20394, 100000 };
            int numeroProcurado = 550;
            int numeroProcuradoInexistente = 3333;

            ExibirResultado(numeros, numeroProcurado);
            ExibirResultado(numeros, numeroProcuradoInexistente);
        }

        // Método que aplica a busca linear
        private static int Buscar(int[] array, int elemento)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == elemento)
                {
                    return i;
                }
            }
            return -1;
        }

        private static void ExibirResultado(int[] numeros, int numero)
        {
            int indice = Buscar(numeros, numero);
            if (indice != -1)
            {
                Console.WriteLine($"{numero} encontrado na posição {indice}, valor: {numeros[indice]}");
            }
            else
            {
                Console.WriteLine($"{numero} não encontrado no array.");
            }
        }
    }
}
