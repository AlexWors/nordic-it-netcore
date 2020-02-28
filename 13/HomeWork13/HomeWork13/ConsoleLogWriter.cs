using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork13
{
    public class ConsoleLogWriter : BaseWriterClass
    {
        public override void WriteMessage(string message, MessageType type)
        {
            Console.WriteLine(FormatMessage(message, type));
        }
    }
}
