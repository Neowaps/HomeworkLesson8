// Задача 56: Задайте прямоугольный двумерный массив.
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки
// с наименьшей суммой элементов: 1 строка

void GetSumRows(int[,] arraySum)
{
    int minIndexRow = -1;
    int minRow = -1;
    for (int i = 0; i < arraySum.GetLength(0); i++)
    {
        int temp = 0;
        for (int j = 0; j < arraySum.GetLength(1); j++)
        {
            if (temp <= minRow || i == 0)
            {
                temp += arraySum[i, j];
            }
            else
            {
                continue;
            }
        }
        if (temp < minRow || i == 0)
        {
            minRow = temp;
            minIndexRow = i;
        }
    }
    System.Console.WriteLine($"Индекс строки с наименьшей суммой элементов: {minIndexRow}, а сумма элементов в данной строке равна: {minRow}");
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



System.Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());

int[,] array = new int[m, n];

FillArray(array);
ShowArray(array);
System.Console.WriteLine();
GetSumRows(array);
