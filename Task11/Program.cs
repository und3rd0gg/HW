using System;

namespace Task11
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            float usdBalance = 130f;
            float eurBalance = 320f;
            float cnyBalance = 2440f;
            float usdEurRate = 0.91f;
            float usdCnyRate = 6.37f;
            float eurUsdRate = 1.09f;
            float eurCnyRate = 6.97f;
            float cnyUsdRate = 0.16f;
            float cnyEurRate = 0.14f;
            string userInput = "";

            while (userInput != "exit")
            {
                Console.WriteLine($"Ваш баланс: \nUSD: {usdBalance}\nEUR: {eurBalance}\nCNY: {cnyBalance}");
                Console.WriteLine("Введите действие: ");
                Console.WriteLine("1. USD -> EUR");
                Console.WriteLine("2. USD -> CNY");
                Console.WriteLine("3. EUR -> USD");
                Console.WriteLine("4. EUR -> CNY");
                Console.WriteLine("5. CNY -> USD");
                Console.WriteLine("6. CNY -> EUR");
                Console.WriteLine("Введите exit чтобы завершить программу.");
                userInput = Console.ReadLine();
                int selectedAction = 0;
                
                if (userInput != "exit")
                {
                    selectedAction = Convert.ToInt32(userInput);
                }
                
                Console.WriteLine("Введите количество валюты для конвертации");
                int amountToConvert = Convert.ToInt32(Console.ReadLine());

                switch (selectedAction)
                {
                    case 1:
                        
                        usdBalance -= amountToConvert;
                        eurBalance += amountToConvert * usdEurRate;
                        break;
                    
                    case 2:
                        
                        usdBalance -= amountToConvert;
                        cnyBalance += amountToConvert * cnyUsdRate;
                        break;
                    
                    case 3:

                        eurBalance -= amountToConvert;
                        usdBalance += amountToConvert * eurUsdRate;
                        break;
                    
                    case 4:

                        eurBalance -= amountToConvert;
                        cnyBalance += amountToConvert * eurCnyRate;
                        break;
                    
                    case 5:

                        cnyBalance -= amountToConvert;
                        usdBalance += amountToConvert * cnyUsdRate;
                        break;
                    
                    case 6:

                        cnyBalance -= amountToConvert;
                        eurBalance += amountToConvert * cnyEurRate;
                        break;
                }
            }
        }
    }
}