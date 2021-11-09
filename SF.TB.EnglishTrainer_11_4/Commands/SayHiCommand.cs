using System;
using System.Collections.Generic;
using System.Text;

namespace SF.TB.EnglishTrainer_11_4
{
    public class SayHiCommand : AbstractCommand, IChatTextCommand
    {
        public SayHiCommand()
        {
            CommandText = "/saymehi";
        }

        public string ReturnText()
        {
            return "привет";
        }

    }

}
