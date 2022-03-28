using System;

namespace Task12
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string name = "";
            string password = "";
            string userInput = "";

            while (userInput != "Esc")
            {
                Console.WriteLine("Введите команду");
                Console.WriteLine("SetName – установить имя\nChangeConsoleColor- изменить цвет консоли" +
                                  "\nSetPassword – установить пароль\nWriteName – вывести имя\n" +
                                  "DeletePassword - Удалить пароль\nEsc – выход из программы");
                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "SetName":

                        if (name != "")
                            Console.WriteLine("Имя уже существует, если вы продолжите, оно будет перезаписано");

                        Console.WriteLine("Введите желаемое имя");
                        name = Console.ReadLine();
                        break;

                    case "ChangeConsoleColor":
                        Console.WriteLine(
                            "Введите желаемый цвет консоли: \nGreen - Зеленый\nWhite - Белый\nBlack - Черный\nRed - Красный");
                        string selectedColor = Console.ReadLine();

                        switch (selectedColor)
                        {
                            case "Green":

                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Clear();
                                break;

                            case "White":

                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.BackgroundColor = ConsoleColor.White;
                                Console.Clear();
                                break;

                            case "Black":

                                Console.ForegroundColor = ConsoleColor.White;
                                Console.BackgroundColor = ConsoleColor.Black;
                                Console.Clear();
                                break;

                            case "Red":

                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                break;
                        }

                        break;

                    case "SetPassword":

                        if (password != "")
                        {
                            Console.WriteLine("Введите старый пароль:");
                            string inputPassword = Console.ReadLine();

                            if (inputPassword != password)
                            {
                                Console.WriteLine("Введен неправильный пароль\n");
                                continue;
                            }
                        }

                        Console.WriteLine("Введите новый пароль");
                        password = Console.ReadLine();
                        Console.WriteLine("Пароль изменен\n");
                        break;

                    case "WriteName":

                        if (password != "")
                        {
                            Console.WriteLine("Введите пароль");
                            string inputPassword = Console.ReadLine();

                            if (inputPassword != password)
                            {
                                Console.WriteLine("Пароль введен неправильно\n");
                                continue;
                            }
                        }

                        Console.WriteLine($"Ваше имя: {name}");
                        break;

                    case "DeletePassword":

                        if (password != "")
                        {
                            Console.WriteLine("Введите пароль");
                            string inputPassword = Console.ReadLine();

                            if (inputPassword != password)
                            {
                                Console.WriteLine("Пароль введен неправильно");
                                continue;
                            }
                        }

                        Console.WriteLine("Введите новый пароль");
                        password = Console.ReadLine();
                        Console.WriteLine("Пароль успешно изменен\n");
                        break;
                }
            }
        }
    }
}