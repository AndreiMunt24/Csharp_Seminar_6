 void Main()
    {
        // Запрос ввода строки от пользователя
        Console.WriteLine("Введите строку для проверки на палиндром: ");
        string input = Console.ReadLine(); // Чтение строки, введенной пользователем
        
        // Преобразование строки: удаление пробелов и приведение к нижнему регистру
        string processedInput = input.Replace(" ", "").ToLower();

        // Создание перевернутой версии строки
        char[] charArray = processedInput.ToCharArray();
        Array.Reverse(charArray);
        string reversedInput = new string(charArray);

        // Проверка, является ли строка палиндромом
        if (processedInput == reversedInput)
        {
            Console.WriteLine("Введенная строка является палиндромом.");
        }
        else
        {
            Console.WriteLine("Введенная строка не является палиндромом.");
        }
    }
Main();
