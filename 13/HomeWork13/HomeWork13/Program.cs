using System;

namespace HomeWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            var consoleWriter = new ConsoleLogWriter();
            consoleWriter.WriteMessage("Writing...", MessageType.Info);

            var fileWriter = new FileLogWriter(@"C:\Users\111\nordic-it-netcore\13\HomeWork13\HomeWork13\bin\log.txt");
            fileWriter.WriteMessage("Writing...", MessageType.Error);
        }
    }
}
