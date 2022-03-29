using System;

namespace Task13
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Введите имя");
            string name = Console.ReadLine();
            Console.WriteLine("Введите символ");
            string symbol = Console.ReadLine();
            Console.Clear();
            int rows = 3;
            int columns = name.Length + 2;
            int cursorDefaultPositionX = 0;
            int cursorDefaultPositionY = 0;

            for (int i = rows; i > 0; i--)
            {
                
                for (int j = columns; j > 0; j--)
                {
                    Console.Write(symbol);
                    cursorDefaultPositionY = j + 1;
                }
                
                Console.WriteLine();
                cursorDefaultPositionX = i;
            }

            int cursorNamePositionX = 1;
            int cursorNamePositionY = 1;
            Console.SetCursorPosition(cursorNamePositionX,cursorNamePositionY);
            Console.Write(name);
            Console.SetCursorPosition(cursorDefaultPositionX, cursorDefaultPositionY);
        }
    }
}