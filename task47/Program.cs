// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9
double[,] FillMatrix(int rowsCount, int columnsCount)
{
    double[,] matrix = new double[rowsCount, columnsCount];  // размер матрицы из случайных чисел
    double minRange = -9.99;       // диапозон случайных чисел
    double maxRange = +9.99;
    Random rand = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = rand.NextDouble()*(maxRange - minRange) + minRange;
                                                                        // заполнение ячеек матрицы
        }
        
    }
    
    return matrix;
}
void PrintMatrix(double[,] matrix)                          // метод  печать матрицы
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]:f2}  ");  // с двумя знаками после запятой                                           
        }
        Console.WriteLine();   
        Console.WriteLine();                                                                       
    }
}

Console.Write("Введите число строк (m): "); 
int m = Convert.ToInt32(Console.ReadLine()); 
Console.Write("Введите число стобцов (n): "); 
int n = Convert.ToInt32(Console.ReadLine()); 
if (m < 0 || m > 20 || n < 0 || n > 20)     // проверка на ввод
{
Console.WriteLine("Bведите положительное число не больше 20");
return;
}
double[,] matrix = FillMatrix(m, n);  // вызов метода заполнения массива
Console.WriteLine();
PrintMatrix(matrix);     //  вызов метода печати массива