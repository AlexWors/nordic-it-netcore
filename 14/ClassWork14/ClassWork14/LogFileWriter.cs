using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ClassWork14
{
    class LogFileWriter
    {
        public string FileName { get; }

        public LogFileWriter(string filename)
        {
            FileName = filename;
        }

        public void WriteLog(string message)
        {
            var sw = new StreamWriter(File.Open(FileName, FileMode.Append, FileAccess.Write, FileShare.None));
            sw.WriteLine($"{DateTimeOffset.UtcNow:O}\t{message}");
            //sw.Flush();
            sw.Close();
        }
    }
}
