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
            int firstSearchLowerLimit = 100;
            int secondSearchLowerLimit = 0;
            int searchUpperLimit = 999;
            int foundMultiplesCount = 0;
            
            while (secondSearchLowerLimit < firstSearchLowerLimit)
            {
                secondSearchLowerLimit += numberN;
            }

            for (int i = secondSearchLowerLimit; i <= searchUpperLimit; i += numberN)
            {
                foundMultiplesCount++;
            }

            Console.WriteLine($"Число N: {numberN}, Количество трехзначных кратных чисел: {foundMultiplesCount}");
        }
    }
}