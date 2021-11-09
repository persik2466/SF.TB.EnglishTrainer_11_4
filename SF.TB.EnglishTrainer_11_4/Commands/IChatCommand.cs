using System;
using System.Collections.Generic;
using System.Text;
//using TelegramBot.EnglishTrainer.Model;

namespace SF.TB.EnglishTrainer_11_4
{
    /// <summary>
    /// Интерфейс базовой команды чата
    /// </summary>
    public interface IChatCommand
    {
        bool CheckMessage(string message);
    }

}
