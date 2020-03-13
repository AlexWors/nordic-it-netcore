using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork13
{
    class MultipleLogWriter : BaseWriterClass
    {
        private static MultipleLogWriter _multipleLogWriter;

        private IEnumerable<ILogWriter> _logWriters;

        public static MultipleLogWriter GetInstance() => _multipleLogWriter ??= new MultipleLogWriter();

        private MultipleLogWriter() =>
            _logWriters = new List<ILogWriter> { ConsoleLogWriter.GetInstance(), FileLogWriter.GetInstance() };

        public MultipleLogWriter(params ILogWriter[] writers)
        {
            _logWriters = writers;
        }

         public override void WriteMessage(string message, MessageType type)
        {
            foreach(var item in _logWriters)
            {
                switch (type)
                {
                    case MessageType.Error:
                        item.LogError(message);
                        break;
                    case MessageType.Info:
                        item.LogInfo(message);
                        break;
                    case MessageType.Warning:
                        item.LogWarning(message);
                        break;
                }
            }
        }
    }
}
