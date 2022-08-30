// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3

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
            Console.Write(matrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
}
Console.Write("Введите число строк: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число стобцов: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] matrix = FillMatrix(m,n); // вызов метода заполнения массива случайными числами
PrintMatrix(matrix);             // вызов метода вывода массива 
SumAverageColumn(matrix);        // вызов метода подсчета среднего арифметического значения столбцов

void SumAverageColumn(int[,] matrix)
{
    double sum = 0;
    double aver = 0;
    Console.Write("Среднее арифметическое значение столбцов: ");
   
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum = sum + matrix[i, j];
            aver = sum / matrix.GetLength(0);
           
        }
         Console.Write($"{aver:f2}" + "  ");
    }
}
