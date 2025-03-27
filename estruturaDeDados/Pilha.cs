using System;

namespace Algoritmos
{
    public class Pilha
    {
        private int[] _itens;
        private int _topo;
        private int _tamanhoMaximo;

        public Pilha(int tamanhoMaximo)
        {
            _tamanhoMaximo = tamanhoMaximo;
            _itens = new int[tamanhoMaximo];
            _topo = -1;
        }

        public void Push(int item)
        {
            if (_topo >= _tamanhoMaximo - 1)
            {
                Console.WriteLine("A pilha está cheia! Não foi possível adicionar o item.");
                return;
            }

            _itens[++_topo] = item;
            Console.WriteLine($"{item} foi adicionado a pilha.");
        }

        public int Pop()
        {
            if (_topo == -1)
            {
                Console.WriteLine("A pilha está vazia! Não há itens para remover.");
                return -1;
            }

            int item = _itens[_topo--];
            return item;
        }

        public int Topo()
        {
            if (_topo == -1)
            {
                Console.WriteLine("A pilha está vazia! Não há itens para remover.");
                return -1;
            }

            return _itens[_topo];
        }

        public bool estaVazia()
        {
            return _topo == -1;
        }

        public void Exibir()
        {
            if (_topo == -1)
            {
                Console.WriteLine("A pilha está vazia.");
                return;
            }

            Console.WriteLine("Itens da pilha:");
            for (int i = _topo; i >= 0; i--)
            {
                Console.WriteLine(_itens[i]);
            }
        }
    }
}