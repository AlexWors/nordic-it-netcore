using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork17
{
    class RandomDataGenerator
    {
        public delegate void RandomDataGeneratedHandler(int bytesDone, int totalBytes);
        public event RandomDataGeneratedHandler RandomDataGenerated;
        public event EventHandler RandomDataGenerationDone;

        public byte[] GetRandomData(int dataSize, int bytesDoneToRaiseEvent)
        {
            byte[] result = new byte[dataSize];
            var rand = new Random();
            //easy
            //for(int i = 0; i < dataSize; i++)
            //{
            //    result[i] = (byte)rand.Next(256);
            //}

            int packageaNumber = dataSize / bytesDoneToRaiseEvent;
            int elementInLastPackage = dataSize % bytesDoneToRaiseEvent;
            for(int i = 0; i < packageaNumber; i++)
            {
                byte[] package = new byte[packageaNumber];
                rand.NextBytes(package);
                package.CopyTo(result, i * bytesDoneToRaiseEvent);
                RandomDataGenerated?.Invoke(i * bytesDoneToRaiseEvent, dataSize);
            }

            if(elementInLastPackage > 0)
            {
                byte[] package = new byte[elementInLastPackage];
                rand.NextBytes(package);
                package.CopyTo(result, dataSize - elementInLastPackage);
            }

            RandomDataGenerationDone?.Invoke(this, EventArgs.Empty);
            return result;
        }
    }
}
