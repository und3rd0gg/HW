using System;

namespace Task17
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string stringToCheck = "(()(()(())))";
            int openBracketsCount = 0;
            int closingBracketsCount = 0;
            int depth = 0;
            int maxDepth = 0;

            foreach (var symbol in stringToCheck)
            {

                if (symbol == '(')
                {
                    openBracketsCount++;
                    depth++;
                }
                else if (symbol == ')')
                {
                    closingBracketsCount++;
                    depth--;
                }

                if (maxDepth < depth)
                {
                    maxDepth = depth;
                }
            }

            if (openBracketsCount != closingBracketsCount)
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