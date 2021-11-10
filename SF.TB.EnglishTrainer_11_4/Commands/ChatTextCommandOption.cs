﻿using System;

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

        public string ClearMessageFromCommand(string message)
        {
            return message.Substring(CommandText.Length + 1);
        }
    }
}
