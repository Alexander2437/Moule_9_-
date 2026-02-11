using Moule_9_Практикум_App;

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
            //    new MyException("Некорректный параметр сортировки."),
            //    new DivideByZeroException("Деление на ноль"),
            //    new FormatException("Неверный формат")
            //};

            //foreach (var ex in exceptions)
            //{
            //    try
            //    {
            //        throw ex;
            //    }
            //    catch (Exception exception)
            //    {
            //        Console.WriteLine("Поймано исключение: " + exception.Message);
            //    }
            //    finally
            //    {
            //        Console.WriteLine($"Итерация с исключением {ex} завершена.");
            //    }
            //}



            //Задание 2



            List<string> surnames = new List<string>() { "Иванов", "Смирнов", "Петров", "Дуров", "Юсупов" };

            SortHelper sorter = new SortHelper();
            sorter.SortEvent += delegate (List<string> surnames, bool ascending)
            {
                if (ascending)
                {
                    surnames.Sort();
                }
                else
                {
                    surnames.Sort();
                    surnames.Reverse();
                }
            };

            byte numeric = 0;
            bool condition = false;

            do
            {
                Console.WriteLine("Укажите порядок сортировки: 1 - в алфавитном порядке, 2 - в обратном порядке.");
                var sortBy = Console.ReadLine();

                try
                {
                    numeric = byte.Parse(sortBy);
                    if (numeric == 1 || numeric == 2)
                    {
                        condition = true;
                    }
                    else
                    {
                        condition = false;
                        throw new MyException("Некорректный порядок сортировки.");
                    }
                }
                catch (MyException e)
                {
                    Console.WriteLine(e.Message);
                    condition = false;
                }
                catch (Exception)
                {
                    Console.WriteLine("Некорректный порядок сортировки.");
                    condition = false;
                }
            }
            while (condition == false);

            switch (numeric)
            {
                case 1:
                    sorter.TriggerSort(surnames, true);
                    condition = true;
                    break;
                case 2:
                    sorter.TriggerSort(surnames, false);
                    condition = true;
                    break;
            }

            foreach (var name in surnames)
            {
                Console.WriteLine(name);
            }
        }
    }
}
