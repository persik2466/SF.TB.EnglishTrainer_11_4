using System;
using System.Collections.Generic;
using System.Text;

namespace SF.TB.EnglishTrainer_11_4
{
    /// <summary>
    /// Класс команды с дополнительным текстом после команды
    /// </summary>
    public abstract class ChatTextCommandOption : AbstractCommand
    {
        public override bool CheckMessage(string message)
        {
            return message.StartsWith(CommandText);
        }
        /// <summary>
        /// Отделение команды от слова
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public string ClearMessageFromCommand(string message)
        {
            return message.Substring(CommandText.Length + 1);
        }

    }

}
