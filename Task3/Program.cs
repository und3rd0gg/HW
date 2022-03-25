using System;

namespace Task3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int pictureCount = 52;
            int rowCount = 3;
            Console.WriteLine($"Количество заполненных рядов = {pictureCount / rowCount}, количество картинок сверх меры: {pictureCount % rowCount}");
        }
    }
}