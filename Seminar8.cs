// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] IntMatrix(int m, int n)
{
    int[,] matrix = new int[m, n];

    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        for(int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 10);
            Console.Write($"{matrix[i, j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    return matrix;
}

void SortMatrix(int[,] matr)
{
    for(int k = 0; k < matr.GetLength(0); k++)
    {
        for(int l = 0; l < matr.GetLength(1); l++)
        {
            for(int sort = 0; sort < matr.GetLength(1) - 1; sort++)
            {
                if(matr[k,sort] < matr[k, sort + 1])
                {
                    int temp = matr[k, sort];
                    matr[k,sort] = matr[k, sort + 1];
                    matr[k, sort + 1] = temp;
                } 
            }
        }
    }
    ShowMatrix(matr);
}

void ShowMatrix(int[,] sortedMatrix)
{
    for (int row = 0; row < sortedMatrix.GetLength(0); row++)
    {
        for (int col = 0; col < sortedMatrix.GetLength(1); col++)
        {
            Console.Write($"{sortedMatrix[row, col]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

SortMatrix(IntMatrix(3, 4));