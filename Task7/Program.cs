using System;

namespace Task7
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string message;
            Console.Write("Введите сообщение: ");
            message = Console.ReadLine();
            int repeatCount;
            Console.Write("Введите количество повторов: ");
            repeatCount = Convert.ToInt32(Console.ReadLine());
            
            while (repeatCount > 0)
            {
                Console.WriteLine(message);
                repeatCount--;
            }
        }
    }
}