// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void FillArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = Convert.ToDouble(new Random().Next(-10, 1000))/100;
        }
    }
}

void PrintArray(double[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write(arr[i,j] + " ");
        }
        Console.WriteLine();
    }
}

int m = GetNumberFromConsole("Введите колличество строк массива m");
int n = GetNumberFromConsole("Введите колличество столбцов массива n");
double[,] array = new double[m,n];
FillArray(array);
PrintArray(array);