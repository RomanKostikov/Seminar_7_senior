// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Main()
{
    Console.Clear();

    Console.Write("Enter the number of rows array: ");
    int rows = int.Parse(Console.ReadLine()!);
    Console.Write("Enter the number of columns array: ");
    int columns = int.Parse(Console.ReadLine()!);
    int[,] array = GetArray(rows, columns);
    Console.WriteLine("Array:");
    PrintArray(array);
    Console.WriteLine("Arithmetic mean of each column:");
    ArithmeticSum(array);
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
void ArithmeticSum(int[,] arr)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            sum += arr[i, j];
        }
        Console.Write($"{Math.Round((sum / arr.GetLength(0)), 2)}; ");
    }
}

Main();