using System;
using Telegram.Bot.Types.ReplyMarkups;


namespace SF.TB.EnglishTrainer_11_4
{
    /// <summary>
    /// Интерфейс кнопок
    /// </summary>
    interface IKeyBoardCommand
    {
        InlineKeyboardMarkup ReturnKeyBoard();

        void AddCallBack(Conversation chat);

        string InformationalMessage();
    }
}
