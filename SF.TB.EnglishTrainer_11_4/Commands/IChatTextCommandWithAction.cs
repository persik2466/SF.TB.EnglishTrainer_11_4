using System;

namespace SF.TB.EnglishTrainer_11_4
{
    /// <summary>
    /// 
    /// </summary>
    interface IChatTextCommandWithAction : IChatTextCommand
    {
        bool DoAction(Conversation chat);
    }
}
