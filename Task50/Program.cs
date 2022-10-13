// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

int GetNumberFromConsole(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int GetRandomValue(int minValue, int maxValue)
{
    return new Random().Next(minValue, maxValue + 1);
}

void FillArray(int[,] arr, int minValue, int maxValue)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            arr[i,j] = GetRandomValue(minValue,maxValue);
        }
    }
}

void PrintArray(int[,] arr)
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

int[,] InitializateArray(int m, int n)
{
    return new int[m,n];
}

void ChekSearch(int[,] arr, int a, int b)
{
       if ((a< arr.GetLength(0)) && (b < arr.GetLength(1)))
        {
        Console.WriteLine($"Элемент в строке {a} столбце {b} равен : {arr[a,b]}");
        }
        else
        {
        Console.WriteLine("Такой позиции нет в массиве!");
        }
}

int m = GetNumberFromConsole("Введите колличество строк в массиве m");
int n = GetNumberFromConsole("Введите колличество столбцов в массиве n");
int[,] array = InitializateArray(m,n);
int minValue = GetNumberFromConsole("Введите минимальное число, допустимое в массиве");
int maxValue = GetNumberFromConsole("Введите максимальное число, допустимое в массиве");
FillArray(array,minValue,maxValue);
PrintArray(array);
int a = GetNumberFromConsole("Введите номер строки элемента ");
int b = GetNumberFromConsole("Введите номер столбца элемента ");
ChekSearch(array, a, b);