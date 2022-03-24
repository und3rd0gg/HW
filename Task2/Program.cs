using System;

namespace Task2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Как вас зовут?: ");
            string name = Console.ReadLine();
            Console.Write("Какой ваш возраст?: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Какой ваш знак зодиака?: ");
            string zodiacSign = Console.ReadLine();
            Console.Write("Вы работаете на: ");
            string workplace = Console.ReadLine();
            Console.WriteLine($"Вас зовут: {name}, ваш возраст: {age} год, ваш знак зодиака: {zodiacSign}, вы работаете на {workplace}");
        }
    }
}