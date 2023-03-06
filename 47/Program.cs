// Задайте двумерный массив 
// размером m×n, заполненный случайными вещественными числами.

int SizeOfMatrix(string text)
{
    Console.WriteLine(text);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void FillMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            int num = new Random().Next(-100, 100);
            matrix[i,j] = new Random().NextDouble() + num;
        }
    }
}

void PrintMatrix(double[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        Console.WriteLine("\n");
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows, columns]} | ");
        }
    }
}

double[,] matrix = new double[SizeOfMatrix("Количество строк:"),
                                SizeOfMatrix("Количество столбцов:")];

FillMatrix(matrix);
PrintMatrix(matrix);