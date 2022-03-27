using System;

namespace Task10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int number = random.Next(0, 101);
            int summ = 0;
            Console.WriteLine(number);
            
            for (; number > 0; number--)
            {
                
                if (number % 3 == 0 || number % 5 == 0)
                {
                    summ += number;
                }
                
            }
            
            Console.WriteLine($"Полученная сумма = {summ}");
        }
    }
}