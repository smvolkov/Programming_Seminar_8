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

void ShowMatrix(int[,] newMatrix)
{
    for (int row = 0; row < newMatrix.GetLength(0); row++)
    {
        for (int col = 0; col < newMatrix.GetLength(1); col++)
        {
            Console.Write($"{newMatrix[row, col]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

//SortMatrix(IntMatrix(3, 4));

// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void MinRow(int[,] lowMatr)
{
    int lowestRow = 0;
    int lowestRowNumber = 1;
    for(int i = 0; i < lowMatr.GetLength(0); i++)
    {
        int currentRow = 0;
        for(int j = 0; j < lowMatr.GetLength(1); j++)
        {
            currentRow += lowMatr[i, j];
        }

        if (i == 0) lowestRow = currentRow;
        if (currentRow < lowestRow)
        {
            lowestRowNumber = i + 1;
            lowestRow = currentRow;
        }

    }

    Console.WriteLine($"{lowestRowNumber} строка");
}

//MinRow(IntMatrix(4, 4));

// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

void MatrixProduct(int[,] matrixA, int[,] matrixB)
{
    int[,] productedMatrix = new int[matrixA.GetLength(0), matrixB.GetLength(1)];

    for (int i = 0; i < productedMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < productedMatrix.GetLength(1); j++)
        {
            int elementIJ = 0;
            for(int k = 0; k < matrixA.GetLength(1); k++)
            {
                elementIJ += matrixA[i, k] * matrixB [k, j];
            }
            productedMatrix[i,j] = elementIJ;
        }
    } 
    ShowMatrix(productedMatrix);
}

MatrixProduct(IntMatrix(3, 2), IntMatrix(2, 3));