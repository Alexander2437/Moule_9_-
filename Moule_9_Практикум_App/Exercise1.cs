using Moule_9_Практикум_App;

namespace Module_9_Практикум_App
{
    internal static class Exercise1
    {
        public static void ShowExceptions()
        {
            Exception[] exceptions = new Exception[]
                        {
                new ArgumentNullException("param", "Аргумент не может быть null"),
                new InvalidOperationException("Неверная операция"),
                new MyException("Некорректный параметр сортировки."),
                new DivideByZeroException("Деление на ноль"),
                new FormatException("Неверный формат")
                        };

            foreach (var ex in exceptions)
            {
                try
                {
                    throw ex;
                }
                catch (Exception exception)
                {
                    Console.WriteLine("Поймано исключение: " + exception.Message);
                }
                finally
                {
                    Console.WriteLine($"Итерация с исключением {ex} завершена.");
                }
            }
        }
    }
}