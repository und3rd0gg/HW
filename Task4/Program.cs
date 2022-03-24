using System;

namespace Task4
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            string firstName = "Dylan";
            string lastName = "Bob";
            Console.WriteLine($"Значение переменных до перестановки: firstName = {firstName} lastName = {lastName}");
            string buffer = lastName;
            lastName = firstName;
            firstName = buffer;
            Console.WriteLine($"Значение переменных после перестановки: firstName = {firstName} lastName = {lastName}");
        }
    }
}