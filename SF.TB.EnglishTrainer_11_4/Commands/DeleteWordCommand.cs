﻿using System;

namespace SF.TB.EnglishTrainer_11_4
{
    /// <summary>
    /// Класс команды удаления слова
    /// </summary>
    public class DeleteWordCommand : ChatTextCommandOption, IChatTextCommandWithAction
    {
        public DeleteWordCommand()
        {
            CommandText = "/deleteword";
        }

        public bool DoAction(Conversation chat)
        {
            var message = chat.GetLastMessage();

            var text = ClearMessageFromCommand(message);

            if (chat.dictionary.ContainsKey(text))
            {
                chat.dictionary.Remove(text);
                return true;
            }

            return false;
        }

        public string ReturnText()
        {
            return "Слово успешно удалено!";
        }
    }
}
