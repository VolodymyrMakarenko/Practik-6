using System;
using System.IO;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        Console.OutputEncoding = UTF8Encoding.UTF8;
        string fileName = "C:\\Users\\Acer\\source\\repos\\Practik 6\\Practik 6\\input.txt"; // назва файлу з даними
        int min = int.MaxValue; // мінімальне значення (ініціалізуємо максимальним значенням int)
        int max = int.MinValue; // максимальне значення (ініціалізуємо мінімальним значенням int)

        try
        {
            using (StreamReader reader = new StreamReader(fileName))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    int value = int.Parse(line); // перетворюємо рядок у ціле число
                    if (value < min)
                    {
                        min = value;
                    }
                    if (value > max)
                    {
                        max = value;
                    }
                }
            }
            Console.WriteLine("Мінімальне значення: {0}", min);
            Console.WriteLine("Максимальне значення: {0}", max);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine("Файл не знайдено.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Файл містить некоректні дані.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Сталася помилка: {0}", ex.Message);
        }

        Console.ReadKey();
    }
}