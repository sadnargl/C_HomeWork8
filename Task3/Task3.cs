int MatrixSize = InputFigureFromConsole ("Введите размер двумерной матрицы: ");
if (MatrixSize == -1)
    { 
    Console.WriteLine ("Число введено с ошибкой");
    System.Environment.Exit (0);
    }
int [,] matrix1 = RandomFeelTwoDimensionsArray (MatrixSize,MatrixSize);
int [,] matrix2 = RandomFeelTwoDimensionsArray (MatrixSize,MatrixSize);
int [,] resultmatrix = MatrixMultiplication (matrix1, matrix2);

PrintArray (matrix1);
Console.WriteLine ();
PrintArray (matrix2);
Console.WriteLine ();
PrintArray (resultmatrix);

int InputFigureFromConsole (string invitation)
{
    Console.Write (invitation);
    int i;
    while (!int.TryParse (Console.ReadLine(), out i))
    {
        Console.WriteLine ("Ошибка ввода числа");
        Console.Write (invitation);
    }
    if (i>=1) {return i;} else {return -1;}
}

int [,] RandomFeelTwoDimensionsArray (int FirstLength, int SecondLength)
{
    int [,] Array = new int [FirstLength,SecondLength];
    Random rnd = new Random ();
    for (int i = 0; i < Array.GetLength(0); i++)
    {
       for (int j = 0; j < Array.GetLength(1); j++)
       {
        Array [i,j]= (int)rnd.NextInt64 (0,255);
       } 
    }
    return Array;
}

void PrintArray (int [,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
          Console.Write ($"{Array [i,j]} ");  
        }
        Console.WriteLine ();
    }
}

int [,] MatrixMultiplication (int [,] Array1, int [,] Array2)
{
    int [,] result = new int [Array1.GetLength(0), Array1.GetLength(0)];
 
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(0); j++)
        {
            result [i,j] = 0;
            for (int k = 0; k < result.GetLength(0); k++)
            {
                 result [i,j] = result [i,j] + Array1 [i,k]*Array2 [k,j];
            } 
        }
    }
    return result;
}