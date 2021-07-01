using System;
using System.Collections.Generic;
using System.Text;

namespace TelegramBotEnglishTrainer.Commands
{
    public interface IChatCommand
    {
        bool CheckMessage(string message);
    }
}
