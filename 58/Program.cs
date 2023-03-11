/* Задайте две матрицы. 
Напишите программу, которая будет находить произведение двух матриц. */

int GetValueFromUser(string message)
{
    Console.WriteLine(message);
    int value = Convert.ToInt32(Console.ReadLine());
    return value;
}

void FillMatrix(int[,] matrix)
{
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            matrix[rows, columns] = new Random().Next(1, 100);
        }
    }
}

void PrintMatrix(int[,] matrix, string text)
{
    Console.WriteLine("\n");
    Console.Write(text);
    for (int rows = 0; rows < matrix.GetLength(0); rows++)
    {
        Console.WriteLine("\n");
        for (int columns = 0; columns < matrix.GetLength(1); columns++)
        {
            Console.Write($"{matrix[rows, columns]} | ");
        }
    }
}

bool RuleOfMatrixMultiplication(int[,] MatrOne, int[,] MatrTwo)
{
    if(MatrOne.GetLength(1) == MatrTwo.GetLength(0)) return true;
    else return false;
}

void MultiplicationResult(int[,] one, int[,] two, int[,] result)
{
    for (int i = 0; i < one.GetLength(0); i++)
            {
                for (int j = 0; j < two.GetLength(1); j++)
                {
                    for (int l = 0; l < one.GetLength(1); l++)
                    {
                        result[i, j] += one[i, l] * two[l, j];
                    }
                }
            }
}

Console.WriteLine("количество столбцов первой матрицы должно быть равно количеству строк второй матрицы");
Console.WriteLine("Задайте матрицу 1: ");
int[,] matrixOne = new int[GetValueFromUser("Количество строк > "),
                            GetValueFromUser("Количестов столбцов > ")];
Console.WriteLine("Задайте матрицу 2: ");
int[,] matrixTwo = new int[GetValueFromUser("Количество строк > "),
                            GetValueFromUser("Количестов столбцов > ")];

FillMatrix(matrixOne);
FillMatrix(matrixTwo);
PrintMatrix(matrixOne, "\n Матрица 1: ");
PrintMatrix(matrixTwo, "\n Матрица 2: ");

if(RuleOfMatrixMultiplication(matrixOne, matrixTwo))
{
    int[,] resultMatrix = new int[matrixOne.GetLength(0), matrixTwo.GetLength(1)];
    MultiplicationResult(matrixOne, matrixTwo, resultMatrix);
    PrintMatrix(resultMatrix, "\n Результат произведения: ");
    
}
else Console.WriteLine("\n Такие матрицы перемножить нельзя. Нарушено правило умножения матриц");

