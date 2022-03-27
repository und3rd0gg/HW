using System;

namespace Task9
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int startNumber = 5;
            int endNumber = 96;
            int difference = 7;

            for (int increasingNumber = startNumber; increasingNumber <= endNumber; increasingNumber += difference)
            {
                Console.WriteLine(increasingNumber);
            }
        }
    }
}