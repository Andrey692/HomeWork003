// Задайте двумерный массив. Напишите программу,
// которая поменяет местами первую и последнюю строку массива.

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] GenerateMatrix(int row, int col, int leftRange, int rightRange)
{ 
    int[,] tempMatrix = new int[row, col];      
    Random rand = new Random();
    for (int i = 0; i < tempMatrix.GetLength(0); i++)      
    
        for (int j = 0; j < tempMatrix.GetLength(1); j++)
        
            tempMatrix[i,j] = rand.Next(leftRange, rightRange + 1);
        
    return tempMatrix;

}

void PrintMatrix(int[,] MatrixForPrint)
{
    for (int i = 0; i < MatrixForPrint.GetLength(0); i++)    
    {
        for (int j = 0; j < MatrixForPrint.GetLength(1); j++)
        {
            System.Console.Write(MatrixForPrint[i,j] + "\t");
        }      
        System.Console.WriteLine();
    }
}

void ChengeMatrix(int[,] matrix, int row1, int row2)
{
    int col = matrix.GetLength(1); 
    int temp;
    for (int i = 0; i < col; i++)
    {
        temp = matrix[row1, i];
        matrix[row1, i] = matrix[row2,i];
        matrix[row2, i] = temp;
    }
}

int rows = ReadInt("Введите колличество строк в массиве: ");
int cols = ReadInt("Введите колличество столбцов в массиве: ");

int [,] matrix = GenerateMatrix(rows, cols, -9, 9);

PrintMatrix(matrix);

ChengeMatrix(matrix, 0, rows - 1);

System.Console.WriteLine();

PrintMatrix(matrix);

