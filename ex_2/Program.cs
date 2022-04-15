// Задача 2: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.


int RandomNum()
{
    Random rnd = new Random();
    int digit = rnd.Next(10);
    return digit;
}

int[,] FillMatrix(int row, int collumn)
{
    int[,] matrix = new int[row, collumn];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = RandomNum();
        }
    }
    return matrix;
}


void PrintMatrix(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            Console.Write($"{collection[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void TheElemInMatrix(int[,] matrix, int posRow, int posCollumn)
{
    if (1 > posRow || posRow > matrix.GetLength(0) || 1>  posCollumn || posCollumn > matrix.GetLength(1))
    {
        Console.WriteLine($"Элемента со значениями {posRow} и {posCollumn} нету в матрице.");
    }
    Console.WriteLine(matrix[posRow, posCollumn]);
}

int[,] ar = FillMatrix(5, 5);
PrintMatrix(ar);
Console.WriteLine();
TheElemInMatrix(ar, 1, 1);



