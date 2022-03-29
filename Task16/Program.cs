using System;

namespace Task16
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Random random = new Random();
            int randomStartValue = 0;
            int randomEndValue = 1001;
            int number = random.Next(randomStartValue, randomEndValue);
            double two = 2;
            double twoInPower = 0;
            double power = 0;

            while (twoInPower < number)
            {
                power++;
                twoInPower = Math.Pow(two, power);
            }
            
            Console.WriteLine($"Число: {number}, Степень: {power}");
        }
    }
}