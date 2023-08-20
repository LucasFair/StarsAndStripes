using System.ComponentModel;

namespace StarsAndStripesV2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char emptySpc = ' ';
            char starChar = '*';
            byte[] flagArray = new byte[]  // Array contains the coordinates needed for the flag's construction
                {
                11,  // Blue height
                23,  // Blue width
                15,  // Short red and white width, and bottom height
                38  // Wide red and white width
                };

            for (byte heightCnt = 0; heightCnt < flagArray[0]; heightCnt++)  // Blue part of the flag
            {
                for (byte widthCnt = 0; widthCnt < flagArray[1]; widthCnt++)
                {
                    switch (heightCnt % 2)  // Runs the switch through 0 to 1, then repeats
                    {
                        case 0:
                            Console.BackgroundColor = ConsoleColor.Blue;
                            if ((widthCnt + 6) % 4 == 1)  // Swifts the star position and displays 6 stars for its own rows
                            {
                                if (heightCnt > 1 && heightCnt < 10)  // Star row 0 and 11 are changed filled with nothing
                                {
                                    Console.Write(starChar);
                                }
                                else
                                {
                                    Console.Write(emptySpc);
                                }
                            }
                            else
                            {
                                Console.Write(emptySpc);
                            }
                            Console.ResetColor();
                            break;
                        case 1:
                            Console.BackgroundColor = ConsoleColor.Blue;
                            if (widthCnt % 4 == 1)  // Sets the star position, has 5 stars
                            {
                                Console.Write(starChar);
                            }
                            else
                            {
                                Console.Write(emptySpc);
                            }
                            break;
                    }
                }
                for (byte restFlag = 0; restFlag < flagArray[2]; restFlag++)  // Short bottom part
                {
                    switch (heightCnt % 4)  // Runs the switch through from 0 to 3, then repeats
                    {
                        case 0:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(emptySpc);
                            break;
                        case 1:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(emptySpc);
                            break;
                        case 2:
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(emptySpc);
                            break;
                        case 3:
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(emptySpc);
                            break;
                    }
                }
                Console.WriteLine(string.Empty);  // Adds line breaks to create rows
            }

            for (byte height = 0; height < flagArray[0]; height++)  // Bottom wide part
            {
                for (byte width = 0; width < flagArray[3]; width++)
                {
                    switch (height % 4)
                    {
                        case 0:  // Shifted the row to match up with the 11th spot
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(emptySpc);
                            break;
                        case 1:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(emptySpc);
                            break;
                        case 2:
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.Write(emptySpc);
                            break;
                        case 3:
                            Console.BackgroundColor = ConsoleColor.White;
                            Console.Write(emptySpc);
                            break;
                    }
                }
                Console.WriteLine(string.Empty);  // Adds line breaks to create rows
            }
            Console.ResetColor();  // Resets the color of the console
        }
    }
}

