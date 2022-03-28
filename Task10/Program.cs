using System;

namespace Task10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int randomStartNumber = 0, randomEndNumber = 101;
            int number = random.Next(randomStartNumber, randomEndNumber);
            int summ = 0;

            for (; number > 0; number--)
            {
                bool isNumberMultiplesBy3 = number % 3 == 0;
                bool isNumberMultiplesBy5 = number % 5 == 0;
                if (isNumberMultiplesBy3 || isNumberMultiplesBy5)
                {
                    summ += number;
                }
            }
            
            Console.WriteLine($"Полученная сумма = {summ}");
        }
    }
}