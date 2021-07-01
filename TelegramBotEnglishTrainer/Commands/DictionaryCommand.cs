using System;
using System.Collections.Generic;
using System.Text;
using TelegramBotEnglishTrainer.EnglishTrainer.Model;

namespace TelegramBotEnglishTrainer.Commands
{
    public class DictionaryCommand : ChatTextCommandOption, IChatTextCommandWithAction
    {
        string textDictionary;
        public DictionaryCommand()
        {
            CommandText = "/dictionary";
            textDictionary = "";
        }
        
        public bool DoAction(Conversation chat)
        {
            int num = 1;
            foreach (KeyValuePair<string, Word> keyValue in chat.dictionary)
            {
                textDictionary += num + ". " + keyValue.Value.Russian + " - " + keyValue.Value.English + 
                    " - " + keyValue.Value.Theme + " ";
                num++;
            }
            return true;
        }
        public string ReturnText()
        {
            return "Список слов:" + textDictionary;
        }
    }
}
