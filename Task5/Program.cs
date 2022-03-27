using System;

namespace Task5
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int crystalPrice = 30;
            int goldBalance, crystalBalance = 0;
            Console.Write("Введите начальное количество золота: ");
            goldBalance = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите количество кристаллов для покупки: ");
            int crystalsToBuy;
            crystalsToBuy = Convert.ToInt32(Console.ReadLine());
            crystalBalance += crystalsToBuy;
            goldBalance -= crystalsToBuy * crystalPrice;
            Console.WriteLine($"Остаток золота: {goldBalance}, остаток кристаллов: {crystalBalance}");
        }
    }
}