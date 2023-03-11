/* Сформируйте трёхмерный массив из 
неповторяющихся двузначных чисел. 
Напишите программу, которая будет построчно выводить массив,
 добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2 */



void FillMatrix(int[,,] matrix)
{
    for (int i = 0; i < 2; i++)
    {
        for (int j = 0; j < 2; j++)
        {
            for (int l = 0; l < 2; l++)
            {
                matrix[j,l,i] = new Random().Next(10,100);
            }
        }
    }
    
}



void PrintMatrix(int[,,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
        {
            Console.WriteLine("\n");
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                
                for (int k = 0; k < matrix.GetLength(2); k++)
                {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k})   ");
                }
                
            }
        }
}

int[,,] matrix = new int[2, 2, 2];

FillMatrix(matrix);
PrintMatrix(matrix);
