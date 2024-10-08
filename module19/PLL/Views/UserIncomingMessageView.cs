﻿using module19.BLL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace module19.PLL.Views
{
    public class UserIncomingMessageView
    {
        public void Show(IEnumerable<Message> incomingMessages)
        {
            Console.WriteLine("Входящие сообщения");


            if (incomingMessages.Count() == 0)
            {
                Console.WriteLine("Входящих сообщения нет");
                return;
            }

            incomingMessages.ToList().ForEach(message =>
            {
                Console.WriteLine("От кого: {0}. Текст сообщения: {1}", message.SenderEmail, message.Content);
            });
        }
    }
}