// Задача 54: Задайте двумерный массив. Напишите программу,
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


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

void SortArray(int[,] arraySort)
{
    for (int i = 0; i < arraySort.GetLength(0); i++)
    {
        for (int j = 0; j < arraySort.GetLength(1); j++)
        {
            for (int l = j + 1; l < arraySort.GetLength(1); l++)
            {
                if (arraySort[i, l] > arraySort[i, j])
                {
                    int temp = arraySort[i, j];
                    arraySort[i, j] = arraySort[i, l];
                    arraySort[i, l] = temp;
                }
            }
        }
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
SortArray(array);
ShowArray(array);
