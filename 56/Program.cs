/* Задайте прямоугольный двумерный массив. 
Напишите программу, которая будет находить строку 
с наименьшей суммой элементов. */

int GetValueFromUser(string massage)
{
    Console.WriteLine(massage);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void FillMatrix(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(1,100);
        }
    }
}

void PrintMatrix(int[,] matrix)
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

int[] SumOfRow(int[,] matrix) // Суммы строк в одномерный массив
{
    int[] array = new int[matrix.GetLength(0)];
    int i = 0;
    int rows = 0;
    while(i < array.Length)
    {
        int sum = 0;
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            sum = sum + matrix[rows, columns];
        }
        array[i] = sum; 
        i++;
        rows++;  
    }
    
return array;
}

int FindMinSumOfRow(int[] array) // Минимальная сумма из массива
{
    int min = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < min) min = array[i];
    }
    return min;
}

int FindNumberOfMinRow(int[] array, int n) // Номер строки с мин.суммой
{
    int numberOfMinRow = 1;
    for (int i = 0; i < array.Length; i++)
    {
        if (n == array[i]) numberOfMinRow = i; 
    }
    return numberOfMinRow + 1;
}

int[,] matrix = new int[GetValueFromUser("Количество строк > "), 
                        GetValueFromUser("Количество столбцов > ")];
FillMatrix(matrix);
PrintMatrix(matrix);
int minrow = FindMinSumOfRow(SumOfRow(matrix));
int numberOfMinRow = FindNumberOfMinRow(SumOfRow(matrix), minrow);
Console.WriteLine("");
Console.WriteLine($"Минимальная сумма: {minrow} в строке {numberOfMinRow}");