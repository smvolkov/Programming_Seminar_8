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

//MatrixProduct(IntMatrix(3, 2), IntMatrix(2, 3));

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

void Array3d(int m, int n, int o)
{
    int[,,] arr = new int[m, n, o];

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                //arr[i, j, k] = new Random().Next((i+j+k+1)*10, (i+j+k+1)*20);
                int temp = new Random().Next(10, 100);
                int flag = 0;
                for (int f = 0; f < arr.GetLength(0); f++)
                {
                    for (int g = 0; g < arr.GetLength(1); g++)
                    {
                        for (int h = 0; h < arr.GetLength(2); h++)
                        {
                            if (arr[f, g, h] == temp)
                            {
                                flag = 1;
                                break;
                            }

                        }

                        if (flag == 1) break;
                    }

                    if (flag == 1)
                    {
                        temp = new Random().Next(10, 100);
                        f = -1;
                        flag = 0;
                    }
                }

                arr[i, j, k] = temp;
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
            }

            Console.WriteLine();
        }
    }

    
}

//Array3d(2, 2, 2);

// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void SpiralArray(int m, int n)
{
    int[,] spArr = new int[m,n];

    int row = 0;
    int col = 0;
    int x = 1;
    int y = 0;
    int direction = 0;
    int lim = n;

    for (int k = 0; k < spArr.Length; k++)
    {
        spArr[row, col] = k + 1;
        lim--;

        if (lim == 0)
        {
            lim = n*(direction % 2) + m*((direction + 1)%2) - (direction/2 - 1) - 2;
            int temp = x;
            x = -y;
            y = temp;
            direction++;
        }

        col += x;
        row += y;
    }

    for(int i = 0; i < spArr.GetLength(0); i++)
    {
        for (int j = 0; j < spArr.GetLength(1); j++)
        {
            Console.Write($"{spArr[i, j].ToString("00")} ");
        }
        Console.WriteLine();
    }

}

SpiralArray(4, 4);