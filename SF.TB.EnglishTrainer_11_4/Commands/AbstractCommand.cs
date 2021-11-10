using System;

namespace SF.TB.EnglishTrainer_11_4
{
    /// <summary>
    /// абстрактная команда чата, определяет является ли сообщение командой
    /// </summary>
    public abstract class AbstractCommand : IChatCommand
    {
        public string CommandText;

        public virtual bool CheckMessage(string message)
        {
            return CommandText == message;
        }
    }
}
