using System;

namespace ClassWork4_2
{
    class Program
    {
        [Flags]
        enum Colors
        {
            Black = 1,
            Blue = 2,
            Cyan = 3,
            Grey = 4,
            Green = 5,
            Magneta = 6,
            Red = 7,
            White = 8,
            Yellow = 9
        };


        static void Main(string[] args)
        {
            
            Colors allColors = Colors.Black | Colors.Blue | Colors.Cyan | Colors.Green | Colors.Grey | Colors.Magneta | Colors.Red | Colors.White | Colors.Yellow;

            const int maxFavoriteColors = 4;
            Colors favoriteColors = 0;
            for(int i = 0; i < maxFavoriteColors; i++)
            {
                string input = Console.ReadLine();
                favoriteColors |= (Colors)Enum.Parse(typeof(Colors), input);
            }

            
            
        }
    }
}
