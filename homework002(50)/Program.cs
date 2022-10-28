// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)

void Main()
{
    Console.Clear();

    Console.Write("Enter the number of rows array: ");
    int rows = int.Parse(Console.ReadLine()!);
    Console.Write("Enter the number of columns array: ");
    int columns = int.Parse(Console.ReadLine()!);
    int[,] array = GetArray(rows, columns);
    PrintArray(array);
    Console.Write("Enter the index of the array row: ");
    int indexRow = int.Parse(Console.ReadLine()!);
    Console.Write("Enter the index of the array columns: ");
    int indexColumns = int.Parse(Console.ReadLine()!);
    FindPosition(array, indexRow, indexColumns);
}

int[,] GetArray(int m, int n)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(0, 10);
        }
    }
    return result;
}

void FindPosition(int[,] arr, int indexRow1, int indexColumns1)
{
    if (indexRow1 < arr.GetLength(0) && indexColumns1 < arr.GetLength(1))
    {
        Console.Write($"{arr[indexRow1, indexColumns1]} -> There is such a number");
    }
    else
    {
        Console.Write($"[{indexRow1}, {indexColumns1}] -> There is no such a number");
    }
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

Main();