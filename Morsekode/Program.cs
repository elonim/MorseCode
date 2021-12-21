using System;
using System.Threading;

namespace Morsekode
{
    class Program
    {


        private static void changeConsoleColor( ConsoleColor color )
        {
            Console.ForegroundColor = color;
        }



        static void Main( string[] args )
        {


            while ( true )
            {
                Console.Clear();
                changeConsoleColor( ConsoleColor.DarkGreen );
                Console.WriteLine( "\n\t\tMorseCode Translator" );
                MorseHandler morseHandler = new MorseHandler();
                changeConsoleColor( ConsoleColor.Gray );
                Console.Write( "\n\twrite a sentence to get it translated into morse: " );


                var input = Console.ReadLine().ToUpper();
                try
                {
                    var morse = morseHandler.convertToMorse( input );
                    changeConsoleColor( ConsoleColor.DarkBlue );
                    Console.Write( "\t" + input );
                    changeConsoleColor( ConsoleColor.DarkGray );
                    Console.Write( " \n\tin morsecode : " + morse );
                    morseHandler.playMorse( morse );
                    Console.WriteLine();
                }
                catch ( Exception ex )
                {
                    changeConsoleColor( ConsoleColor.Red );
                    Console.WriteLine( "\tFailed : " + ex.Message );
                    Thread.Sleep( 2500 );
                }


            }
        }
    }
}
