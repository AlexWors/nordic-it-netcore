using System;
using System.IO;
namespace ClassWork14
{
    class Program
    {
        static void Main(string[] args)
        {

            Calculations.FileWriter = new LogFileWriter(@"c:\text.txt");
            //Calculations calc = new Calculations();
            Console.WriteLine(Calculations.Add(7, 12));
            Console.WriteLine(Calculations.Multiply(6, 6));


            //using (var errorList = new ErrorList("Category"))
            //{
            //    errorList.Add("bad");
            //    errorList.Add("very bad");

            //    foreach (var error in errorList)
            //    {
            //        using (var logger = new LogFileWriterExtended(@".\..\log\log3.txt"))
            //        {
            //            logger.WriteLog($"Error category {errorList.Category}: {error}");
            //        }
            //    }
            //}


            //Console.WriteLine(File.Exists(filePath));

            //Console.WriteLine(Path.GetDirectoryName(filePath));
            //Console.WriteLine(Path.Combine(@"C:\", @"somepath\"));

            //var logger = new LogFileWriter(@".\..\log\log.txt");
            //logger.WriteLog(Path.GetFullPath(logger.FileName));

            //logger.WriteLog("Thank's");

            //var logger2 = new LogFileWriterExtended(@".\..\log\log2.txt");
            //logger2.WriteLog(Path.GetFullPath(logger2.FileName));

            //logger2.WriteLog("Thank's");
            //logger2.Dispose();

            //using (var logger3 = new LogFileWriterExtended(@".\..\log\log3.txt"))
            //{
            //    logger3.WriteLog(Path.GetFullPath(logger3.FileName));
            //    logger3.WriteLog("Thank's");
            //}

            //Console.WriteLine();
        }
    }
}
