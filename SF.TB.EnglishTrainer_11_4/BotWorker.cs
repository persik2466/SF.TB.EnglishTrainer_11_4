using System;
using System.Collections.Generic;
using System.Text;
using Telegram.Bot;
using Telegram.Bot.Args;


namespace SF.TB.EnglishTrainer_11_4
{

    /// <summary>
    /// Класс для инициализации бота
    /// </summary>
    public class BotWorker
    {
        private ITelegramBotClient botClient;
        private BotMessageLogic logic;
        /// <summary>
        /// Создание клиента бота
        /// </summary>
        public void Inizalize()
        {
            botClient = new TelegramBotClient(BotCredentials.BotToken);
            logic = new BotMessageLogic(botClient);

        }
        /// <summary>
        /// Начало отправки сообщений
        /// </summary>
        public void Start()
        {
            botClient.OnMessage += Bot_OnMessage;
            botClient.StartReceiving();
        }
        /// <summary>
        /// Завершение процесса отправки сообщений
        /// </summary>
        public void Stop()
        {
            botClient.StopReceiving();
        }

        private async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            if (e.Message != null)
            {
                await logic.Response(e);
            }
        }
    }

}
