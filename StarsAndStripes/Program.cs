using System;

//int shrtRed, shrtWht = 14;
//int longRed, longWht = 38;

class AmericanFlag
{
    private static void Main(string[] args)
    {
        // Length = 38;
        // Height = 26;

        //  Variables, declarations, definitions.
        string spcTxt = "   ";
        int shrtLen = 14;
        int lngLen = 38;
        int blueLen = lngLen - shrtLen;
        var shrtSpc = String.Concat(Enumerable.Repeat(spcTxt, shrtLen));
        var lngSpc = String.Concat(Enumerable.Repeat(spcTxt, lngLen));
        var blueSpc = String.Concat(Enumerable.Repeat(spcTxt, blueLen));
        var blueStar_A = String.Concat(Enumerable.Repeat("  *         ", 6));  // 12
        var blueStar_B = String.Concat(Enumerable.Repeat("        *   ", 5));
        string blueStar_Spc = "            ";  // 12

        Console.BackgroundColor = ConsoleColor.Black;  // Makes the background black.

        //  Top part of the flag
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(blueSpc);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(shrtSpc);
        }
        //  This is a mess....
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(blueStar_A);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(shrtSpc);
        }
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(blueStar_B + blueStar_Spc);
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(shrtSpc);
        }
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(blueStar_A);
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(shrtSpc);
        }
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(blueStar_B + blueStar_Spc);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(shrtSpc);
        }
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(blueStar_A);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(shrtSpc);
        }
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(blueStar_B + blueStar_Spc);
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(shrtSpc);
        }
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(blueStar_A);
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(shrtSpc);
        }
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(blueStar_B + blueStar_Spc);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(shrtSpc);
        }
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(blueStar_A);
            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine(shrtSpc);
        }
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Write(blueSpc);
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(shrtSpc);
        }
        // End of blue part
        {
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(lngSpc);
        }
        // Bottom of the flag
        {
            for (int itrEx = 0; itrEx < 3; itrEx++)  // I want to cry...
            {
                for (int itr = 0; itr < 2; itr++)
                {
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine(lngSpc);
                }
                for (int itr = 0; itr < 2; itr++)
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.WriteLine(lngSpc);
                }
            }
            for (int itr = 0; itr < 2; itr++)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine(lngSpc);
            }
            Console.BackgroundColor = ConsoleColor.Black;  // Ensures that the background stays black
        }
    }
}