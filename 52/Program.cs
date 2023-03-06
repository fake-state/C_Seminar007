// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.

int GetValueFromUser(string massage)
{
    Console.WriteLine(massage);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void FillArray(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(1,100);
        }
    }
}

void Average(int[,] matrix)
{
    for (int columns = 0; columns < matrix.GetLength(1); columns++)
    {
        int sum = 0;
        for (int rows = 0; rows < matrix.GetLength(0); rows++)
        {
            sum = sum + matrix[rows, columns];
        }
        Console.WriteLine($"Среднее арифметическое столбца {columns + 1} > {sum / matrix.GetLength(0)}");
    }
}

int[,] matrix = new int[GetValueFromUser("Количество строк > "),
                        GetValueFromUser("Количество столбцов > ")];

FillArray(matrix);
Average(matrix);