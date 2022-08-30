// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

while (true)
{
    void FillMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = new Random().Next(0, 100);
            }
        }
    }

    void PrintMatrix(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write($"{matrix[i, j]} ");
            }
            Console.WriteLine();
        }
    }

    void PrintArray(double[] array)
    {
        Console.Write("Средние арифметические каждого столбца (соответственно) равны: ");
        for (int i = 0; i < array.Length - 1; i++)
        {
            Console.Write($"{array[i]}; ");
        }
        Console.WriteLine($"{array[array.Length - 1]}.");
    }

    double[] ColumnElemAverage(int[,] matrix)
    {
        double[] ColumnElemAverage = new double[matrix.GetLength(1)];

        for (int i = 0; i < matrix.GetLength(1); i++)
        {
            double sum = 0;
            for (int j = 0; j < matrix.GetLength(0); j++)
            {
                sum += matrix[j, i];
            }
            ColumnElemAverage[i] = Math.Round(sum / matrix.GetLength(0), 1);
        }
        return ColumnElemAverage;
    }

    Console.WriteLine("Введите количество строк матрицы");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите количество столбцов матрицы");
    int n = Convert.ToInt32(Console.ReadLine());
    int[,] matrix = new int[m, n];

    FillMatrix(matrix);
    PrintMatrix(matrix);
    Console.WriteLine();
    PrintArray(ColumnElemAverage(matrix));

    Console.WriteLine("Для завершения введите end, для продолжения - любой символ");
    string a = Console.ReadLine();
    if (a == "end")
    {
        break;
    }
}
