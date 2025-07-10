using System;

namespace algoritmos
{
    public class Fila(int tamanhoMaximo)
    {
        private int[] _itens = new int[tamanhoMaximo];
        private int _inicio = 0;
        private int _fim = -1;
        private int _tamanho = 0;
        private int _tamanhoMaximo = tamanhoMaximo;

        public void Enfileirar(int item)
        {
            if (_tamanho == _tamanhoMaximo)
            {
                Console.WriteLine("A fila já está cheia! item não adicionado.");
                return;
            }

            _fim = (_fim + 1) % _tamanhoMaximo;
            _itens[_fim] = item;
            _tamanho++;
            Console.WriteLine($"{item} foi adicionado à fila.");
        }

        public int Desinfileirar()
        {
            if (ChecarFilaVazia())
            {
                Console.WriteLine("A fila está vazia! Não há itens para remover.");
                return -1;
            }

            int item = _itens[_inicio];
            _inicio = (_inicio + 1) % _tamanhoMaximo;
            _tamanho--;
            return item;
        }

        public int ExibirPrimeiroItem()
        {
            if (ChecarFilaVazia())
            {
                Console.WriteLine("A fila está vazia!");
                return -1;
            }

            return _itens[_inicio];
        }

        public bool ChecarFilaVazia()
        {
            return _tamanho == 0;
        }

        public void Exibir()
        {
            if (ChecarFilaVazia())
            {
                Console.WriteLine("A fila está vazia.");
                return;
            }

            Console.WriteLine("Itens da fila:");
            for (int i = 0; i < _tamanho; i++)
            {
                int index = (_inicio + i) % _tamanhoMaximo;
                Console.WriteLine(_itens[index]);
            }
        }
    }
}