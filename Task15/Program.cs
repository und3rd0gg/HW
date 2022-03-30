using System;

namespace Task15
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int randomStartValue = 1;
            int randomEndValue = 28;
            int numberN = random.Next(randomStartValue, randomEndValue);
            int foundMultiplesCount = 0;
            int searchLowerLimit = 100;
            int searchUpperLimit = 1000;

            for (int i = numberN; i < searchUpperLimit; i += numberN)
            {
            
                if (searchLowerLimit <= i)
                {
                    foundMultiplesCount++;
                }
                
            }

            Console.WriteLine($"Число N: {numberN}, Количество трехзначных кратных чисел: {foundMultiplesCount}");
        }
    }
}