using System;
using System.Collections.Generic;
using System.Text;

namespace TelegramBotEnglishTrainer.Commands
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
