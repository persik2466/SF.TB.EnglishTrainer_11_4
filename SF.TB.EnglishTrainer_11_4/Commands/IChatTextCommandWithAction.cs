using System;
using System.Collections.Generic;
using System.Text;

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
