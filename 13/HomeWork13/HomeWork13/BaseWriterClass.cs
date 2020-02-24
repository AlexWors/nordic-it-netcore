using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork13
{
    class BaseWriterClass
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

        public virtual void WriteMessage(string message, MessageType type)
        {

        }
    }
}
