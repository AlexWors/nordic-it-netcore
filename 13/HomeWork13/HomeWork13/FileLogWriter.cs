using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HomeWork13
{
    class FileLogWriter
    {
        private string FileName { get; }

        public FileLogWriter(string fileName)
        {
            FileName = fileName;
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
