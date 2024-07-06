using System; 

class Program
{
    static void Main()
    {
        
        char[,] charArray2D = {
            { 'H', 'e', 'l' },
            { 'l', 'o', ' ' },
            { 'W', 'o', 'r' },
            { 'l', 'd', '!' }
        };

  
        string result = "";

        
        for (int i = 0; i < charArray2D.GetLength(0); i++)
        {
            for (int j = 0; j < charArray2D.GetLength(1); j++)
            {
                
                result += charArray2D[i, j];
            }
        }

        
        Console.WriteLine("Результирующая строка: " + result);
    }
}
