using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork14
{
    class Calculations
    {

        public static LogFileWriter FileWriter { get; set; }

        public static float Add(float a, float b) 
        {
            FileWriter.WriteLog(@"c:\test.txt", $"{a} + {b} = {a + b}");
            return a + b;
        }

        public static float Multiply(float a, float b)
        {
            return a * b;
        }
    }
}
