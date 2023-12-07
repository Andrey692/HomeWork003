// Напишите программу, которая на вход принимает позиции 
// элемента в двумерном массиве, и возвращает 
// значение этого элемента или же указание, что такого элемента нет.

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

int rows = ReadInt("Введите колличество строк в массиве: ");
int cols = ReadInt("Введите колличество столбцов в массиве: ");



int [,] matrix = GenerateMatrix(rows, cols, -9, 9);

PrintMatrix(matrix);

int i = ReadInt("введите индекс строки, нужного элемента:");
int j = ReadInt("введите индекс столбца, нужного элемента:");

if (i < rows && j < cols)
{
    System.Console.WriteLine($"{matrix[i,j]}");
}
else
{
    System.Console.WriteLine("такого элемента нет!");
}
