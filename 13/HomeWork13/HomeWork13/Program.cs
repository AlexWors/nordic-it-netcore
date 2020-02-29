using System;

namespace HomeWork13
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogWriter consoleWriter = new ConsoleLogWriter();
            //consoleWriter.WriteMessage("Writing...", MessageType.Info);
            consoleWriter.LogError("Writing...");

            var fileWriter = new FileLogWriter(@"C:\Users\111\nordic-it-netcore\13\HomeWork13\HomeWork13\bin\log.txt");
            fileWriter.WriteMessage("Writing...", MessageType.Error);

            var multipleWriter = new MultipleLogWriter(new ILogWriter[2] { fileWriter, consoleWriter });

            multipleWriter.LogError("write something about \"error\" ");
            multipleWriter.LogInfo("write something about \"info\" ");
            multipleWriter.LogWarning("write something about \"warning\" ");
        }
    }
}
