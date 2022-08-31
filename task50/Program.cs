// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> такого числа в массиве нет

int[,] FillMatrix(int rowsCount, int columnsCount, int leftRange = -9, int rightRange = 9)
{
    int[,] matrix = new int[rowsCount, columnsCount];

    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.Next(leftRange, rightRange + 1);
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
            Console.Write(matrix[i, j] + "   ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите число строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());//число строк
Console.Write("Введите число стобцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());//число столбцов
int[,] matrix = FillMatrix(m, n);
PrintMatrix(matrix);
Console.Write("Для поиска значения элемента массива ");
Console.Write("введите номер строки: ");
int posM = Convert.ToInt32(Console.ReadLine());
Console.Write("введите номер столбца: ");
int posN = Convert.ToInt32(Console.ReadLine());


if ((posM <= 0 || posM >= matrix.GetLength(0) + 1) || (posN < -0 || posN >= matrix.GetLength(1) + 1))
{
    Console.WriteLine("элемент в массиве отсутствует");
    return;
}

Console.WriteLine("Значение: " + matrix[posM - 1, posN - 1]
+ " находится в строке № " + posM + ", в столбце № " + posN);
