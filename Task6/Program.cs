using System;

namespace Task6
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int grandmothersCount;
            Console.Write("Введите количество старушек: ");
            grandmothersCount = Convert.ToInt32(Console.ReadLine());
            int appointmentTime = 10;
            int timeToWait = grandmothersCount * appointmentTime;
            Console.Write("Вы должны отстоять в очереди ");
            int hour = 60;
            if (timeToWait > hour)
            {
                int hoursToWait = timeToWait / hour;
                Console.Write($"{hoursToWait} часа ");
            }
            int minutesToWait = timeToWait % hour;
            Console.Write($"{minutesToWait} минут.");
        }
    }
}