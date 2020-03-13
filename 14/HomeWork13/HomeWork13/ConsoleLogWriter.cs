using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork13
{
    public class ConsoleLogWriter : BaseWriterClass
    {
        private static ConsoleLogWriter _instance;

        public static ConsoleLogWriter GetInstance() => _instance ??= new ConsoleLogWriter();

        private ConsoleLogWriter() { }

        public override void WriteMessage(string message, MessageType type)
        {
            Console.WriteLine(FormatMessage(message, type));
        }
    }
}
