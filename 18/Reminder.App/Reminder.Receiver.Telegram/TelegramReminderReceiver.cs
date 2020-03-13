using Reminder.Receiver.Core;
using System;
using System.Net;
using Telegram.Bot;
using Telegram.Bot.Types.Enums;

namespace Reminder.Receiver.Telegram
{
    public class TelegramReminderReceiver : IReminderReceiver
    {
        private TelegramBotClient _botClient;

        public TelegramReminderReceiver(string token, IWebProxy proxy)
        {
            _botClient = proxy == null
                ? new TelegramBotClient(token)
                : new TelegramBotClient(token, proxy);
        }

        public event EventHandler<MessageReceivedEventArgs> MessageReceived;

        public void Run()
        {
            _botClient.OnMessage += BotClientOnOnMessage;
            _botClient.StartReceiving();
        }

        private void BotClientOnOnMessage(object sender, global::Telegram.Bot.Args.MessageEventArgs e)
        {
            if(e.Message.Type == MessageType.Text)
            {
                OnMessageReceived(
                    this,
                    new MessageReceivedEventArgs(
                        e.Message.Text,
                        e.Message.Chat.Id.ToString()));
            }
        }
        //в случае наследования
        protected virtual void OnMessageReceived(object sender, MessageReceivedEventArgs e)
        {
            MessageReceived?.Invoke(sender, e);
        }
    }
}
