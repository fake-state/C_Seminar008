// Задайте двумерный массив. Напишите программу, которая 
// упорядочит по убыванию элементы каждой строки двумерного массива.

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

void OrderMaxToMin(int [,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++) // крутим строки матрицы
    {   
        for (int i = 0; i < matrix.GetLength(1); i++) // ко-во проходов по строке
        {
            for (int columns = 0; columns < matrix.GetLength(1) - 1; columns++)
            {
                if(matrix[rows, columns] < matrix[rows, columns + 1])
                {
                    int temp = matrix[rows, columns];
                    matrix[rows, columns] = matrix[rows, columns + 1];
                    matrix[rows, columns + 1] = temp;
                } 
            }
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

int[,] matrix = new int[GetValueFromUser("Количестов строк > "),
                        GetValueFromUser("Количестов столбцов > ")];

FillMatrix(matrix);
OrderMaxToMin(matrix);
PrintMatrix(matrix);