void Main()
    {
        Console.WriteLine("Введите строку, состоящую из слов, разделенных пробелами: ");
        string input = Console.ReadLine(); 
        string[] words = input.Split(' ');
        Array.Reverse(words);

        string reversedString = string.Join(" ", words);
        Console.WriteLine("Строка с словами в обратном порядке: " + reversedString);
    }
Main();
