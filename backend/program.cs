using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Hello, World!");
        Console.WriteLine("Меня зовут Тотьмянин Т.А.");
        Console.WriteLine(DateTime.Now);
        Console.WriteLine("-----------------------------------");

        Console.WriteLine("Введите своё имя: ");
        string name = Console.ReadLine();
        Console.WriteLine($"Привет, {name}!");
        Console.WriteLine(DateTime.Now.DayOfWeek);

        Console.WriteLine("Хотите продолжить? (y/n)");
        string ans = Console.ReadLine();

        if (ans.ToLower() == "y")
        {
            Console.WriteLine("Продолжаем..");
        } 
        else
        {
            Console.WriteLine("Завершаем..");
        }
    }
}

