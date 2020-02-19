using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClassWork14
{
    class LogFileWriterExtended : IDisposable
    {

        private StreamWriter _streamWriter;

        public string FileName { get; }

        public LogFileWriterExtended(string filename)
        {
            FileName = filename;
            _streamWriter = new StreamWriter(File.Open(FileName, FileMode.Append, FileAccess.Write, FileShare.None));
        }

        public void WriteLog(string message)
        {
            _streamWriter.WriteLine($"{DateTimeOffset.UtcNow:O}\t{message}");
            _streamWriter.Flush();
            //sw.Close();
        }

        public void Dispose()
        {
            _streamWriter.Close();
        }
    }
}
