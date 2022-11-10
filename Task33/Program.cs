// Задача 50. Напишите программу, которая на вход принимает  позиции элемента
//  в двумерном массиве, и возвращает значение этого элемента или же указание,
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// [1,7] -> такого числа в массиве нет ([1,7] это позиция элемента)

Console.WriteLine("введите индекс строки");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("введите индекс столбца");
int columns = int.Parse(Console.ReadLine());
int[,] numbers = new int[5, 6];
FillArray(numbers);


if (rows < numbers.GetLength(0) && columns < numbers.GetLength(1))
{
    // Console.WriteLine($"значение элемента {rows} и {columns} равно {numbers [rows-1,columns-1]}");
    Console.WriteLine(numbers[rows, columns]);
}
else
{
    Console.WriteLine($"{rows}{columns} -> такого элемента в массиве нет");
}
PrintArray(numbers);
void FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}
