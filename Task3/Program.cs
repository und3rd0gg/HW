using System;

namespace Task3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int picturesCount = 52;
            int rowCount = 3;
            int filledRows = picturesCount / rowCount;
            int picturesLeft = picturesCount % rowCount;
            Console.WriteLine($"Количество заполненных рядов = {filledRows}, количество картинок сверх меры: {picturesLeft}");
        }
    }
}