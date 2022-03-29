using System;

namespace Task14
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string password = "qwerty";
            string secretMessage = "Секретное сообщение";
            int attemptsCount = 3;
            Console.Write("Введите пароль: ");

            for (int inputAttempts = attemptsCount; inputAttempts > 0; inputAttempts--)
            {
                string userInput = Console.ReadLine();
                
                if (userInput != password)
                {
                    Console.WriteLine($"Введен неправильный пароль. Осталось попыток: {inputAttempts - 1}");
                }
                else
                {
                    Console.WriteLine($"Секретное сообщение: {secretMessage}");
                    break;
                }
            }
        }
    }
}