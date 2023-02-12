using System;


namespace Borysov_.Net
{
    class TestTask
    {
        /// <summary>
        /// Task 1
        /// Составить алгоритм: если введенное число больше 7, то вывести “Привет”
        /// </summary>
        public static void DisplayMessage()
        {
            Console.Write("Введите любое целое число:  ");
            int inputNumber = Convert.ToInt32(Console.ReadLine());
            if (inputNumber > 7)
                Console.WriteLine("Привет");
        }
        
        /// <summary>
        /// Task 2
        /// Составить алгоритм: если введенное имя совпадает с Вячеслав, то вывести “Привет, Вячеслав”, если нет, то вывести "Нет такого имени"
        /// </summary>
        public static void NameVerification()
        {
            Console.Write("Введите имя: ");
            string inputName = Console.ReadLine();
            if (inputName == "Вячеслав")
                Console.WriteLine("Привет, {0}", inputName);
            else Console.WriteLine("Такого имени нет");
        }
        
        /// <summary>
        /// Task 3
        /// Составить алгоритм: на входе есть числовой массив, необходимо вывести элементы массива кратные 3
        /// </summary>
        public static void DisplayMultipleTo3Massive()
        {
            Console.Write("Введите размер массива: ");
            int massiveSize = Convert.ToInt32(Console.ReadLine());
            int[] massiveMultiple = new int[massiveSize];
            Console.WriteLine("Заполните массив: ");
            for(int i = 0; i < massiveSize; i++)
                massiveMultiple[i] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Числа массива, кратные 3: ");
            for(int i = 0; i < massiveMultiple.Length; i++)
            {
                if (massiveMultiple[i] % 3 == 0)
                    Console.Write(" {0} ", massiveMultiple[i]);
            }
            Console.WriteLine();
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            TestTask.DisplayMessage();
            TestTask.NameVerification();
            TestTask.DisplayMultipleTo3Massive();
        }
    }
}
