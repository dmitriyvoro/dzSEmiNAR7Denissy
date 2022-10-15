void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1,11);
        }
    }
}

void PrintMatrix(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write(matrix[i, j] + " \t");
        }
        Console.WriteLine();
    }
}

void ArifmeticElements(int[,] matrix)
{
    Console.WriteLine();
    for (int i = 0; i < matrix.GetLength(1); i++)
    {
        double sum = 0;
        for (int j = 0; j < matrix.GetLength(0); j++)
        {
            sum += matrix[j, i];
        }
        Console.Write(Math.Round(sum / matrix.GetLength(0), 3) + "; ");
    }
}

Console.WriteLine("Введите количество столбцов: ");
int n=Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество строк: ");
int m=Convert.ToInt32(Console.ReadLine());
int[,] matrix = new int[m, n];
InputMatrix(matrix);
PrintMatrix(matrix);
ArifmeticElements(matrix);