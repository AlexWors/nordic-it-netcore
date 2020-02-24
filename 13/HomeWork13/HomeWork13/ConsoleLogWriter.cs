using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork13
{
    class ConsoleLogWriter : BaseWriterClass, ILogWriter
    {


        public override void WriteMessage(string message, MessageType type)
        {
            Console.WriteLine($"{DateTimeOffset.Now:yyyy-MM-ddTHH:MM:ss+0000} {type} {message}");
        }
    }
}
