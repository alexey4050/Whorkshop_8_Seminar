// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Console.Clear();

Console.WriteLine($"Задача 56. Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов. ");

void FillGetMatrix(int [,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
        }
    } 
}

void PrintMatrix(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
    }   
}

Console.WriteLine("Введите размер прямоугольного массива: ");
int massVol = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int [massVol, massVol];
FillGetMatrix(numbers);
PrintMatrix(numbers);

int sum = 0;
int minsum = int.MaxValue;
int indexMinLine = 0;

for (int i = 0; i < numbers.GetLength(0); i++)
{
    sum = 0;
    for (int j = 0; j < numbers.GetLength(1); j++)
    {
        sum = sum + numbers[i, j];
    }
    if (sum < minsum)
    {
        minsum = sum;
        indexMinLine = i+1;
    }
    Console.WriteLine($"Сумма {i+1} - ой строки равна {sum} ");
}

Console.WriteLine($"Строка с наименьшей суммой элементов под номером - {indexMinLine}");
