using System;

namespace Task17
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string stringToCheck = "((()(()))(()))";
            int depth = 0;
            int maxDepth = 0;

            foreach (var symbol in stringToCheck)
            {

                if (symbol == '(')
                {
                    depth++;
                }
                else if (symbol == ')')
                {
                    depth--;
                }

                if (maxDepth < depth)
                {
                    maxDepth = depth;
                }

                if (depth < 0)
                {
                    Console.WriteLine("Некорректное скобочное выражение");
                    break;
                }
            }

            if (depth > 0)
            {
                Console.WriteLine("Некорректное скобочное выражение");
            }
            else
            {
                Console.WriteLine($"Корректное скобочное выражение, максимальная глубина вложенности: {maxDepth}");
            }
            

        }
    }
}