// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

while (true)
{
    int[,] matrix = { { 1, 4, 7, 2 }, { 5, 9, 2, 3 }, { 8, 4, 2, 4 } };
    int[] WritePosition()
    {
        Console.WriteLine("Введите строку и столбец элемента двумерного массива через пробел");
        string pos = Console.ReadLine();
        var position = pos.Split(" ").Select(item => Int32.Parse(item) - 1).ToArray();
        return position;
    }
    void PrintElement(int[,] matrix, int[] position)
    {
        if (
            position[0] < matrix.GetLength(0)
            && position[0] >= 0
            && position[1] < matrix.GetLength(1)
            && position[1] >= 0
        )
        {
            Console.WriteLine($"{matrix[position[0], position[1]]}");
        }
        else
            Console.WriteLine("Числа с таким адресом нет в массиве.");
    }

    int[] position = WritePosition();
    PrintElement(matrix, position);
    Console.WriteLine("Для завершения введите end, для продолжения - любой символ");
    string a = Console.ReadLine();
    if (a == "end")
    {
        break;
    }
}
