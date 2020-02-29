using ClassWork17;
using System;
using System.IO;
using System.IO.Compression;

namespace ConsoleApp1
{
    delegate void WorkPerformedEventHandler(int hours, WorkType workType);

    class Program
    {
        static void Main(string[] args)
        {
            Worker worker = new Worker();
            worker.OnWorkComplete += (workType, hours) =>
            {
                Console.WriteLine($"{workType} complete in {hours} hours.");
            };

            worker.OnWorkHourPassed += Worker_OnWorkHourPassed;

            worker.DoWork(3, WorkType.Work);
            worker.DoWork(2, WorkType.DoNothing);


            var generator = new RandomDataGenerator();
            generator.RandomDataGenerated += Generator_RandomDataGenerated;
            generator.RandomDataGenerationDone += Generator_RandomDataGenerationDone;
            byte[] data = generator.GetRandomData(1024 * 1024, 102_400);
            File.WriteAllBytes("test_bytes.txt", data);
            using (var zipFile = ZipFile.Open("test_bytes.zip", ZipArchiveMode.Create))
            zipFile.CreateEntryFromFile("test_bytes.txt", "test_bytes.txt");

            using FileStream zipFileStream = File.Create("test_bytes.gz");
        }

        private static void Generator_RandomDataGenerationDone(object sender, EventArgs e)
        {

            Console.WriteLine($"{sender.GetHashCode()}: I'm done"); 
        }

        private static void Generator_RandomDataGenerated(int bytesDone, int totalBytes)
        {
            Console.WriteLine($"Generated {bytesDone} from {totalBytes} bytes.");
        }

        private static void Worker_OnWorkHourPassed(WorkType workType, int totalHours, int hoursPassed)
        {
            Console.WriteLine($"{workType} in progress {hoursPassed} hours from {totalHours}.");
        }
    }
}
