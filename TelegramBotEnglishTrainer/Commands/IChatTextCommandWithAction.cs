using System;
using System.Collections.Generic;
using System.Text;

namespace TelegramBotEnglishTrainer.Commands
{
    interface IChatTextCommandWithAction : IChatTextCommand
    {
        bool DoAction(Conversation chat);
    }
}
