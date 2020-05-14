using System.Net;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MihaZupan;

namespace Reminder.Receiver.Telegram.Tests
{
    [TestClass]
    public static class TelegramReminderReceiverTests
    {
        private static TelegramReminderReceiver _telegramReminderReceiver;

        [ClassInitialize]
        public static void ClassInitialize(TestContext tetsContedt)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile(
                    "appsettings.json",
                    false,
                    true)
                .Build();

            IWebProxy proxy = null;

            bool useProxy = bool.Parse(config["telegramBot.UseProxy"]);
            if (useProxy)
            {
                string telegramBotProxyHost = config["telegramBot.Proxy.Host"];
                int telegramBotProxyPort = int.Parse(config["telegramBot.Proxy.Port"]);

                proxy = new HttpToSocks5Proxy(
                    telegramBotProxyHost,
                    telegramBotProxyPort);
            }
            _telegramReminderReceiver = new TelegramReminderReceiver(config, proxy);
        }
        


        [TestMethod]
        public static void GetHelloFromBot_Returns_Not_Empty_String()
        {
            string description = TelegramReminderReceiver.GetHelloFromBot(_);

            Assert.IsNotNull(description);
        }
    }
}
