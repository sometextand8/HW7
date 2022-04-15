// Задача 3: Задайте двумерный массив из целых чисел. 
//Найдите среднее арифметическое элементов в каждом столбце.

int[,] CreateMatrix(int row, int col)
{
    int[,] matrix = new int[row, col];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(10);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}\t");
        }
        Console.WriteLine();
    }
}

void Arifmet(int[,] collection)
{
    for (int i = 0; i < collection.GetLength(0); i++)
    {
        double sum = 0;
        for (int j = 0; j < collection.GetLength(1); j++)
        {
            sum += collection[j, i];
        }
        sum /= collection.GetLength(0);
        Console.WriteLine($"{sum} ");
    }
}



int[,] myMat = CreateMatrix(2, 2);

PrintMatrix(myMat);

Console.WriteLine();

Arifmet(myMat);

