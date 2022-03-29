using System;

namespace Task10
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int randomStartNumber = 0;
            int randomEndNumber = 101;
            int number = random.Next(randomStartNumber, randomEndNumber);
            int divisorByThree = 3;
            int divisorByFive = 5;
            int summ = 0;

            for (; number > 0; number--)
            {
                bool isNumberMultiplesBy3 = number % divisorByThree == 0;
                bool isNumberMultiplesBy5 = number % divisorByFive == 0;
                
                if (isNumberMultiplesBy3 || isNumberMultiplesBy5)
                {
                    summ += number;
                }
            }
            
            Console.WriteLine($"Полученная сумма = {summ}");
        }
    }
}