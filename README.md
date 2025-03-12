# Algoritmos em C#

Este repositório contém implementações de diversos algoritmos clássicos em C#, incluindo algoritmos de ordenação, busca e estruturas de dados.

### Ordenação
    Bubble Sort     ✔
    Selection Sort
    Insertion Sort
    Merge Sort
    Quick Sort 

### Busca
    Busca Linear    ✔
    Busca Binária

### Estruturas de Dados
    Pilha (Stack)
    Fila (Queue)
    Lista Encadeada (Linked List)
    Árvore Binária de Busca (BST)
    Tabela Hash


## Execução
A execução foi feita diretamente com dotnet-script para fins de simplicidade.
- Instale o dotnet-script:
```bash
dotnet tool install -g dotnet-script
```

- Execute o seu código sem precisar compilar(confira se você está no diretório correto):
```bash
dotnet script BuscaLinear.cs
```

## Resumos



### Ordenação

- Bubble sort: Esse algoritmo percorre o array várias vezes, comparando elementos adjacentes e trocando-os se estiverem na ordem errada.
    
    Na função BubbleSort, o primeiro loop externo controla o número de passagens pelo array, e o loop interno compara e troca elementos adjacentes.
    
    O loop interno percorre o array apenas uma vez, mas pode-se ter casos que uma iteração não seja suficiente para ordenar este array; Logo o loop externo é responsável por controlar o número de passagens que o algoritmo faz pelo array; Ou seja, ele determina quantas vezes o algoritmo vai percorrer o array para ordenar todos os elementos.
    
    Mesmo que o array esteja parcialmente ordenado ou já ordenado completamente após uma iteração, o algoritmo continuará percorrendo o array e fazendo as comparações de qualquer maneira, já que o algoritmo não tem uma verificação de "término antecipado"
    

### Busca

- Busca linear (ou busca sequencial): Algoritmo simples para buscar um elemento em um array ou lista. Ele percorre a estrutura de dados elemento por elemento até encontrar o valor desejado ou até atingir o final da lista.
    
    Quando usar? => Quando a lista é pequena ou quando os elementos não estão ordenados;

