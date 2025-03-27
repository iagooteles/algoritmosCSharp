# Algoritmos em C#

Este repositório contém implementações de diversos algoritmos clássicos em C#, incluindo algoritmos de ordenação, busca e estruturas de dados.

### Ordenação
    Bubble Sort     ✔
    Selection Sort  ✔
    Insertion Sort
    Merge Sort
    Quick Sort 

### Busca
    Busca Linear    ✔
    Busca Binária

### Estruturas de Dados
    Pilha (Stack)   ✔
    Fila (Queue)
    Lista Encadeada (Linked List)
    Árvore Binária de Busca (BST)
    Tabela Hash


## Execução
- A execução é feita pelo Program.cs, analise qual algoritmo quer visualizar, comente ou descomente os necessários e execute no seu terminal:
```bash
dotnet run
```

## Resumos



### Ordenação

- Bubble sort: Esse algoritmo percorre o array várias vezes, comparando elementos adjacentes e trocando-os se estiverem na ordem errada.
    
    Na função BubbleSort, o primeiro loop externo controla o número de passagens pelo array, e o loop interno compara e troca elementos adjacentes.
    
    O loop interno percorre o array apenas uma vez, mas pode-se ter casos que uma iteração não seja suficiente para ordenar este array; Logo o loop externo é responsável por controlar o número de passagens que o algoritmo faz pelo array; Ou seja, ele determina quantas vezes o algoritmo vai percorrer o array para ordenar todos os elementos.
    
    Mesmo que o array esteja parcialmente ordenado ou já ordenado completamente após uma iteração, o algoritmo continuará percorrendo o array e fazendo as comparações de qualquer maneira, já que o algoritmo não tem uma verificação de "término antecipado"

    O algoritmo compara dois elementos consecutivos no array e troca-os se estiverem na ordem errada.

- Selection Sort:  É um algoritmo de ordenação simples, porém ineficiente para grandes conjuntos de dados. Ele funciona dividindo o array em duas partes: a parte ordenada (inicialmente vazia) e a parte não ordenada. A cada iteração, ele encontra o menor elemento da parte não ordenada e o move para a parte ordenada.
    
    O algoritmo encontra o menor (ou maior) elemento no array e troca-o com o primeiro elemento não ordenado.
    Ele faz isso para o restante dos elementos, de modo que a cada passagem o próximo menor (ou maior) elemento é colocado na posição correta.



### Busca

- Busca linear (ou busca sequencial): Algoritmo simples para buscar um elemento em um array ou lista. Ele percorre a estrutura de dados elemento por elemento até encontrar o valor desejado ou até atingir o final da lista.
    
    Quando usar? => Quando a lista é pequena ou quando os elementos não estão ordenados;


### Estrutura de dados

- Pilha: 

