// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2

// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Dictionary<int, bool> dict = new Dictionary<int, bool>();
void FillArray(int[,,] arrayCreate)
{
    for (int i = 0; i < arrayCreate.GetLength(0); i++)
    {
        for (int j = 0; j < arrayCreate.GetLength(1); j++)
        {
            for (int l = 0; l < arrayCreate.GetLength(2); l++)
            {
                arrayCreate[i, j, l] = new Random().Next(10, 100);
                while (dict.ContainsKey(arrayCreate[i, j, l]))
                {
                    arrayCreate[i, j, l] = new Random().Next(10, 100);
                }
                dict[arrayCreate[i, j, l]] = true;
            }
        }
    }
}

void ShowArray(int[,,] arrayShow)
{
    for (int i = 0; i < arrayShow.GetLength(2); i++)
    {
        for (int j = 0; j < arrayShow.GetLength(0); j++)
        {
            for (int l = 0; l < arrayShow.GetLength(1); l++)
            {
                System.Console.Write($"{arrayShow[j, l, i]}({j},{l},{i}) ");
            }
            System.Console.WriteLine();
        }
    }
}

System.Console.Write("Введите количество строк массива: ");
int m = int.Parse(Console.ReadLine());
System.Console.Write("Введите количество столбцов массива: ");
int n = int.Parse(Console.ReadLine());
System.Console.Write("Введите глубину массива: ");
int k = int.Parse(Console.ReadLine());

int[,,] array = new int[k, m, n];

FillArray(array);
ShowArray(array);
