using System;


namespace PR12
{
    internal class Program
    {

        /// <summary>
        /// Получить строку в верхнеем реестре
        /// </summary>
        static string GetStrToUpper(string text)
        {
            char[] chars = new char[text.Length];
            for (int i = 0; i < text.Length; i++)
            {
                char symbol = text[i];

                if (symbol >= 'a' && symbol <= 'z')
                    chars[i] = char.ToUpper(symbol); // перевод символов в верхний регистр
                else
                    chars[i] = symbol;
            }

            for (int i = 0; i < text.Length; i++)
            {
                char number = text[i];

                if (number >= '0' && number <= '9') // проверка на содержание цифр
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Вы вводите недопустимые значения!");
                    Console.ReadKey();
                    Environment.Exit(0); // выход из программы 
                }
            }
            return new string(chars);

        }

        static void Main(string[] args)
        {
            Console.Title = "Практическая работа №12";
            while (true)
            {
                Console.WriteLine("Нажмите: Y чтобы продолжить \n\t N чтобы прекратить");
                string select_key = Console.ReadLine();

                switch (select_key)
                {
                    case "Y":

                        try
                        {
                            Console.WriteLine("Здравствуйте!");

                            Console.Write("Введите строку из букв: ");
                            string message = Convert.ToString(Console.ReadLine());

                            if (string.IsNullOrEmpty(message)) // проверка строки на заполненность
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Строка пустая! Вы ничего не ввели.");
                                Console.ReadKey();
                                Environment.Exit(0);
                            }
                            Console.WriteLine();

                            string new_message = GetStrToUpper(message); // вызов функции
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Преобразованная строка:\n" + new_message);
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        catch (ArgumentOutOfRangeException)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Значение аргумента вне диапозона!");
                            Console.ForegroundColor = ConsoleColor.White;
                        }

                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Ошибка ввода данных! " + e.Message);
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        Console.ReadKey();
                        Console.Clear();
                        break;

                    case "N":
                        Console.WriteLine();
                        Environment.Exit(0);
                        break;
                }
            }
        }
        
       
    }
} 
