//Задача 1: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.


double RandomDigitForMatrix()
{
    Random rnd = new Random();
    double digit = Convert.ToDouble(rnd.Next(100)/ 10.0);
    return digit;
}
double[,] FillMatrix(int row, int collumn)
{
    double[,] matrix = new double[row, collumn];

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = RandomDigitForMatrix();
        }
    }
    return matrix;
}
void PrintMatrix(double[,] collection)
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

PrintMatrix(FillMatrix(5, 5));