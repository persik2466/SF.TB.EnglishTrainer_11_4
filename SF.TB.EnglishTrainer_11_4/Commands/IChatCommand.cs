using System;

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
