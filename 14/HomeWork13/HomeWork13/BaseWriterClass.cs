using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork13
{
    public abstract class BaseWriterClass : ILogWriter
    {
        public void LogInfo(string message)
        {
            WriteMessage(message, MessageType.Info);
        }

        public void LogWarning(string message)
        {
            WriteMessage(message, MessageType.Warning);
        }

        public void LogError(string message)
        {
            WriteMessage(message, MessageType.Error);
        }

        public abstract void WriteMessage(string message, MessageType type);

        protected virtual string FormatMessage(string message, MessageType type)
        {
            return $"{DateTimeOffset.Now:yyyy-MM-ddTHH:MM:ss+0000} {type} {message}";
        }
    }
}
