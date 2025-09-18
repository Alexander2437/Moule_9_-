using Moule_9_Практикум_App;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Module_9_Практикум_App
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Задание 1

            //Exception[] exceptions = new Exception[]
            //{
            //    new ArgumentNullException("param", "Аргумент не может быть null"),
            //    new InvalidOperationException("Неверная операция"),
            //    new NewException("Мое собственное исключение"),
            //    new DivideByZeroException("Деление на ноль"),
            //    new FormatException("Неверный формат")
            //};

            //foreach (var ex in exceptions)
            //{
            //    try
            //    {
            //        throw ex;
            //    }
            //    catch (Exception e)
            //    {
            //        Console.WriteLine("Поймано исключение: " + e.Message);
            //    }
            //}

            // Задание 2

            List<string> surnames = new List<string>() { "Иванов", "Смирнов", "Петров", "Дуров", "Юсупов"};

            Console.WriteLine("Начальный список фамилий:");
            PrintList(surnames);

            SortHelper sorter = new SortHelper();
            sorter.SortEvent += (list, asc) =>
            {
                if (asc)
                {
                    list.Sort();
                }
                else
                {
                    list.Sort();
                    list.Reverse();
                }
            };

            bool condition;
            do
            {
                Console.WriteLine("Введите цифрами \"1\" для сортировки списка от А до Я или \"2\" для сортировки от Я до А.");
                string input = Console.ReadLine();

                if (input == "1")
                {
                    sorter.TriggerSort(surnames, true);
                    Console.WriteLine("Cписок отсортирован от А до Я.");
                    PrintList(surnames);
                    condition = true;
                }
                else if (input == "2")
                {
                    sorter.TriggerSort(surnames, false);
                    Console.WriteLine("Cписок отсортирован от Я до А.");
                    PrintList(surnames);
                    condition = true;
                }
                else
                {
                    condition = false;
                    continue;
                }
            }while (condition == false);
        }

        public static void PrintList(List<string> surnameList)
        {
            foreach (string surname in surnameList)
            {
                {
                    Console.WriteLine(surname);
                }
            }
        }
    }
}
