using System;

class Program
{
    static void Main()
    {
        // Вводим массив строк с клавиатуры или задаем его на старте
        string[] inputArray = { "Hello", "2", "world", ":-)" };
        
        // Определяем размер нового массива
        int newSize = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                newSize++;
            }
        }

        // Создаем новый массив нужного размера
        string[] resultArray = new string[newSize];
        
        // Заполняем новый массив строками длиной <= 3 символа
        int j = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[j] = inputArray[i];
                j++;
            }
        }

        // Выводим результат
        Console.WriteLine("Результат:");
        Console.Write("[");
        for (int i = 0; i < resultArray.Length; i++)
        {
            Console.Write($"\"{resultArray[i]}\"");
            if (i < resultArray.Length - 1) 
                Console.Write(", ");
        }
        Console.WriteLine("]");
    }
}