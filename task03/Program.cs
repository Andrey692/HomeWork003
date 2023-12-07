// Задайте прямоугольный двумерный массив. Напишите программу, 
// которая будет находить строку с наименьшей суммой элементов.


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


int SummLine(int[,] matrix, int i)  // подсчет суммы элементов в строке
{
    int sum = matrix[i, 0];
    for (int j = 0; j < matrix.GetLength(1); j++)    
    {
        sum += matrix[i, j];
    }
    return sum;
} 

int rows = ReadInt("Введите колличество строк в массиве: ");
int cols = ReadInt("Введите колличество столбцов в массиве: ");

if (rows > cols || cols >rows)
{
    int [,] matrix = GenerateMatrix(rows, cols, -9, 9);

PrintMatrix(matrix);

    int minSum =1;
int sum = SummLine(matrix, 0);
for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (sum > SummLine(matrix,i))
    {
        sum = SummLine(matrix,i);
        minSum  = i + 1;
    }
}

System.Console.WriteLine($"строка с наименьшей суммой элементов: {minSum}");
}
System.Console.WriteLine("введите прямоугольный массив:");

