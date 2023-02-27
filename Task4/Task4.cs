byte dimension = 2;
byte [,,] result = RandomFeelThreeDimensionsArray (dimension);
PrintArray (result);
Console.WriteLine ();

Byte [,,] RandomFeelThreeDimensionsArray (byte ArrayLength)
{
    Byte [,,] Array = new Byte [ArrayLength,ArrayLength,ArrayLength];
    Random rnd = new Random ();
    string str = string.Empty;
    for (int i = 0; i < Array.GetLength(0); i++)
    {
       for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(2); k++)
            {          
                Array [i,j,k]= (byte)rnd.NextInt64 (10,20);
                while (str.Contains (Array[i,j,k].ToString()))
                {
                    Array [i,j,k]= (byte)rnd.NextInt64 (10,20);
                }
                str = str + Array[i,j,k].ToString()+ " ";
            }
        }
      
    }
    return Array;
}

void PrintArray (byte [,,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            for (int k = 0; k < Array.GetLength(2); k++)
            {
            Console.Write ($" {Array [i,j,k]} ({i}{j}{k})");  
            }
           Console.WriteLine (); 
        } 
    }
        Console.WriteLine ();
}
