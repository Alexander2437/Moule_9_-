namespace Module_9_Практикум_App
{
    class Program
    {
        public static void Main(string[] args)
        {
            bool typeIsCorrect = false;
            int result;

            do
            {
                Console.WriteLine("Выберите задание для проверки: введите \"1\" для первого задания и \"2\" для второго.");
                typeIsCorrect = int.TryParse(Console.ReadLine(), out result);
            }
            while (typeIsCorrect == false || result != 1 && result != 2);

            switch (result)
            {
                case 1:
                    Exercise1.ShowExceptions();
                    break;
                case 2:
                    Exercise2.SortSurnames();
                    break;
            }

        }
    }
}
