using System;

namespace Task8
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            ulong number = 14;
            string userInput = "";

            while (userInput != "exit")
            {
                Console.WriteLine($"Число: {number}");
                number *= number;
                Console.WriteLine("Введите любой символ, чтобы возвести число в квадрат или ");
                Console.WriteLine("введите exit чтобы завершить программу.");
                userInput = Console.ReadLine();
            }
        }
    }
}