using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace HomeWork13
{
    public class FileLogWriter : BaseWriterClass, ILogWriter
    {
        private static FileLogWriter _instance;

        // Имя файла выносим в файл appsettings.json и читаем его оттуда с помощью Microsoft.Extensions.Configuration

        private FileLogWriter() => FileName = "program.log";

        public static FileLogWriter GetInstance() => _instance ??= new FileLogWriter();

        private string FileName { get; }

        public FileLogWriter(string fileName)
        {
            FileName = fileName;
        }

        public override void WriteMessage(string message, MessageType type)
        {
            var fs = File.Open(FileName, FileMode.OpenOrCreate);
            fs.Seek(0, SeekOrigin.End);
            var tw = new StreamWriter(fs);
            tw.WriteLine(FormatMessage(message, type));
            tw.Close();
            fs.Close();
        }
    }
}
