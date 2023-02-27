int FirstDimension = InputFigureFromConsole ("Введите первое измерение массива: ");
int SecondDimension = InputFigureFromConsole ("Введите второе измерение массива: ");
if (FirstDimension == -1 | SecondDimension == -1)
    { 
    Console.WriteLine ("Число введено с ошибкой");
    System.Environment.Exit (0);
    }
byte [,] result = RandomFeelTwoDimensionsArray (FirstDimension,SecondDimension);
PrintArray (result);
Console.WriteLine ();
SortInRowsArray (result);
PrintArray (result);

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

Byte [,] RandomFeelTwoDimensionsArray (int FirstLength, int SecondLength)
{
    Byte [,] Array = new Byte [FirstLength,SecondLength];
    Random rnd = new Random ();
    for (int i = 0; i < Array.GetLength(0); i++)
    {
       for (int j = 0; j < Array.GetLength(1); j++)
       {
        Array [i,j]= (byte)rnd.NextInt64 (0,255);
       } 
    }
    return Array;
}

void PrintArray (byte [,] Array)
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

void SortInRowsArray (byte [,] Array)
{
    Byte maxvalue;
    int maxindex;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1)-1; j++)
        {
            maxvalue = Array [i,j];
            maxindex = j;
            for (int k = j+1; k < Array.GetLength(1); k++)
            {
                if (maxvalue < Array[i,k])
                {
                    maxvalue = Array[i,k];
                    maxindex = k;
                }

            }
            Array[i,maxindex] = Array [i,j];
            Array[i,j] = maxvalue;
        }

    }
}