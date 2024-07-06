void Main()
    {

        Console.WriteLine("Введите строку, содержащую латинские буквы в обоих регистрах: ");
        string input = Console.ReadLine(); 

     
        string result = "";
        
       
        for (int i = 0; i < input.Length; i++)
        {
            char currentChar = input[i];
           
            if (char.IsUpper(currentChar))
            {
               
                result += char.ToLower(currentChar);
            }
            else
            {
               
                result += currentChar;
            }
        }

        
        Console.WriteLine("Результирующая строка: " + result);
    }
Main();
