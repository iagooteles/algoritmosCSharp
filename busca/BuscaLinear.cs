using System;

int[] numeros = {1, 5, 30, 17, 9, 13, 70, 90, 111, 123, 406, 490, 9000, 550, 398776, 20394, 100000};

int numeroProcurado = 550;
int numeroProcuradoInexistente = 3333;

Console.WriteLine(numeroProcurado + ": " + BuscaLinear(numeros, numeroProcurado));
Console.WriteLine(numeros[BuscaLinear(numeros, numeroProcurado)]);
Console.WriteLine(numeroProcuradoInexistente + ": " + BuscaLinear(numeros, numeroProcuradoInexistente));
        
static int BuscaLinear(int[] array, int elemento)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == elemento)
        {
            return i; // retornando o indice do elemento
        }
    }
    return -1; // retornando -1 se o elemento não for encontrado
}
