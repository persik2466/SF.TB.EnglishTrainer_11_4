using System;
using Telegram.Bot;

namespace SF.TB.EnglishTrainer_11_4
{
    /// <summary>
    /// English Trainer базовый уровень. Добавлена команда /dictionary
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            var bot = new BotWorker();

            bot.Inizalize();
            bot.Start();

            Console.WriteLine("Напишите stop для прекращения работы");

            string command;
            do
            {
                command = Console.ReadLine();

            } while (command != "stop");

            bot.Stop();


        }
    }
}
