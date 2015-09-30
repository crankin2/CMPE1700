using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICA3Demo
{
    public class Utils
    {
        public static void PrintError(string Err = "Error", string Dbg = "",
                                    bool printUsage = true, bool exit = false, int exitVal = 1)
        {
            //1 Print out error message
            ConsoleColor currBackColour = Console.BackgroundColor;
            ConsoleColor currForeColour = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Error.WriteLine("Error: " + Err);
            if (Dbg.Length > 0)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Error.WriteLine(Dbg);
            }
            Console.ForegroundColor = currForeColour;
            Console.BackgroundColor = currBackColour;
            if (printUsage)
            {
                PrintUsage();
            }
            Console.ForegroundColor = currForeColour;
            Console.BackgroundColor = currBackColour;

            if (exit)
            {
                Environment.Exit(exitVal); //By convention, exit with a value != 0 for error
            }
        }

        //general usage message
        public static void PrintUsage()
        {
            Console.WriteLine("Usage: " + System.AppDomain.CurrentDomain.FriendlyName + "<val>" +
                @"where val is a \npositive integer greater than zero of no more than 64 bits.\n
                Prints even or odd depending on the amount of set bits.");
        }
    }
}
