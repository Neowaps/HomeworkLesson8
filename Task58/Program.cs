// Задача 58: Задайте два двумерных массива (от 0 до 10).
// Напишите программу, которая будет находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4
// 3 2

// 3 4
// 3 3
// Результирующая матрица будет:
// 6 16
// 9 6



int[,] PowArray(int[,] arrayFirst, int[,] arraySecond)
{
    int m = Math.Max(arrayFirst.GetLength(0), arraySecond.GetLength(0));
    int n = Math.Max(arrayFirst.GetLength(1), arraySecond.GetLength(1));
    int[,] arrayResult = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            if (i >= arrayFirst.GetLength(0) || i >= arraySecond.GetLength(0) || j >= arrayFirst.GetLength(1) || j >= arraySecond.GetLength(1))
            {
                if (i < arrayFirst.GetLength(0) && j < arrayFirst.GetLength(1))
                {
                    arrayResult[i, j] = arrayFirst[i, j];
                }
                else if (i < arraySecond.GetLength(0) && j < arraySecond.GetLength(1))
                {
                    arrayResult[i, j] = arraySecond[i, j];
                }
            }
            else
            {
                arrayResult[i, j] = arrayFirst[i, j] * arraySecond[i, j];
            }
        }
    }
    return arrayResult;
}


void FillArray(int[,] arrayCreate)
{
    for (int i = 0; i < arrayCreate.GetLength(0); i++)
    {
        for (int j = 0; j < arrayCreate.GetLength(1); j++)
        {
            arrayCreate[i, j] = new Random().Next(0, 10);
        }
    }
}

void ShowArray(int[,] arrayShow)
{
    for (int i = 0; i < arrayShow.GetLength(0); i++)
    {
        for (int j = 0; j < arrayShow.GetLength(1); j++)
        {
            System.Console.Write(arrayShow[i, j] + " ");
        }
        System.Console.WriteLine();
    }
}



System.Console.Write("Введите количество строк первого массива: ");
int rowsOne = int.Parse(Console.ReadLine());
System.Console.Write("Введите количество столбцов первого массива: ");
int colOne = int.Parse(Console.ReadLine());
System.Console.Write("Введите количество строк второго массива: ");
int rowsTwo = int.Parse(Console.ReadLine());
System.Console.Write("Введите количество столбцов второго массива: ");
int colTwo = int.Parse(Console.ReadLine());

int[,] arrayOne = new int[rowsOne, colOne];
int[,] arrayTwo = new int[rowsTwo, colTwo];

FillArray(arrayOne);
FillArray(arrayTwo);
System.Console.WriteLine("Первый массив:");
ShowArray(arrayOne);
System.Console.WriteLine();
System.Console.WriteLine("Второй массив:");
ShowArray(arrayTwo);
System.Console.WriteLine();
System.Console.WriteLine("Результат поэлементного произведения: ");
int[,] result = PowArray(arrayOne, arrayTwo);
ShowArray(result);







// Надеюсь, что никто не увидит эту первую кошмарнейшую попытку сделать метод :В

// int[,] PowArray(int[,] arrayFirst, int[,] arraySecond)
// {
//     bool rowsBig;
//     bool colBig;
//     int m = 6;
//     int n = 6;
//     if (arrayFirst.GetLength(0) > arraySecond.GetLength(0))
//     {
//         m = arrayFirst.GetLength(0);
//         rowsBig = true;
//     }
//     else
//     {
//         m = arraySecond.GetLength(0);
//         rowsBig = false;
//     }
//     if (arrayFirst.GetLength(1) > arraySecond.GetLength(1))
//     {
//         n = arrayFirst.GetLength(1);
//         colBig = true;
//     }
//     else
//     {
//         n = arraySecond.GetLength(1);
//         colBig = false;
//     }
//     int[,] arrayResult = new int[m, n];
//     for (int i = 0; i < arrayResult.GetLength(0); i++)
//     {
//         for (int j = 0; j < arrayResult.GetLength(1); j++)
//         {
//             if (j >= arrayFirst.GetLength(1) || j >= arraySecond.GetLength(1) || i >= arrayFirst.GetLength(0) || i >= arraySecond.GetLength(0))
//             {
//                 if (rowsBig) arrayResult[i, j] = arrayFirst[i, j];
//                 else arrayResult[i, j] = arraySecond[i, j];
//                 if (colBig) arrayResult[i, j] = arrayFirst[i, j];
//                 else arrayResult[i, j] = arraySecond[i, j];
//             }
//             if (j < arrayFirst.GetLength(1) && j < arraySecond.GetLength(1) && i < arrayFirst.GetLength(0) && i < arraySecond.GetLength(0))
//             {
//                 arrayResult[i, j] = arrayFirst[i, j] * arraySecond[i, j];
//             }
//         }
//     }
//     return arrayResult;
// }
