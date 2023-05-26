// Доп.Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07


void FillArray(int[,] arrayCreate)
{
    int temp = 1;
    int lenRow = arrayCreate.GetLength(0) - 1;
    int lenCol = arrayCreate.GetLength(1) - 1;
    int row = 0;
    int col = 0;

    while (temp <= arrayCreate.Length)
    {

        for (int i = col; i <= lenCol; i++)
        {
            arrayCreate[row, i] = temp;
            temp++;
        }
        row++;

        for (int i = row; i <= lenRow; i++)
        {
            arrayCreate[i, lenRow] = temp;
            temp++;
        }
        lenCol--;

        for (int i = lenCol; i >= col; i--)
        {
            arrayCreate[lenRow, i] = temp;
            temp++;
        }
        lenRow--;

        for (int i = lenRow; i >= row; i--)
        {
            arrayCreate[i, col] = temp;
            temp++;
        }
        col++;
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

int[,] array = new int[4, 4];
FillArray(array);
ShowArray(array);









// for (int j = 0; j < len; j++)
// {
//     arrayCreate[i, j] = temp;
//     temp++;
// }
// for (int i = 0; i < len; i++)
// {
//     arrayCreate[i, j] = temp;
//     temp++;
// }
// for (int k = len; k > 0 ; k--)
// {
//     arrayCreate[i, j] = temp;
//     temp++;
// }
