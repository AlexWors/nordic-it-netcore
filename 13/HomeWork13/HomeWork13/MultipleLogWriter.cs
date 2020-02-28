using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWork13
{
    class MultipleLogWriter : ILogWriter
    {
        private IEnumerable<ILogWriter> _logWriters;

        public MultipleLogWriter(params ILogWriter[] writers)
        {
            _logWriters = writers;
        }

        public void LogError(string message)
        {
            foreach(var item in _logWriters)
            {
                item.LogError(message);
            }
        }

        public void LogInfo(string message)
        {
            foreach (var item in _logWriters)
            {
                item.LogInfo(message);
            }
        }

        public void LogWarning(string message)
        {
            foreach (var item in _logWriters)
            {
                item.LogWarning(message);
            }
        }
    }
}
