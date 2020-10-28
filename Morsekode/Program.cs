using System;
using System.Threading;

namespace Morsekode
{
    class Program
    {
        private static readonly string[] ALPHABET = { " ", "A", "B", "C", "D", "E", "F", "G", "H", "I", "J", "K",
                                  "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W",
                                  "X", "Y", "Z", "Æ", "Ø", "Å", "1", "2", "3", "4", "5", "6",
                                  "7", "8", "9", "0" };

        //Morsekode abcd....zæøå + tal 1234567890
        private static readonly string[] MORSECODE = { "/", "·—", "—···", "—·—·", "—··", "·", "··—·", "——·", "····",
                                    "··", "·———", "—·—", "·—··", "——", "—·", "———", "·——·", "——·—",
                                    "·—·", "···", "—", "··—", "···—", "·——", "—··—", "—·——", "——··",
                                    "·—·—", "———·", "·——·—", "·————", "··———", "···——", "·····",
                                    "····—", "—····", "——···", "———··", "————", "—————" };
        static void Main(string[] args)
        {
          
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("\tMorseCode Translator");
            Console.ForegroundColor = ConsoleColor.Gray;

            while (true) 
            {
                string beep = "";
                Console.Write("\nwrite a sentence to get it translated into morse: ");


                string indput = Console.ReadLine().ToUpper();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(indput);
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.Write(" in morsecode : ");


                foreach (char c in indput)
                {
                    for (int i = 0; i < ALPHABET.Length; i++)
                    {
                        if (c.ToString() == ALPHABET[i])
                        {
                            Console.Write($"{MORSECODE[i]}  ");
                            beep += MORSECODE[i];
                        }
                    }
                }

                foreach (char c2 in beep)
                {
                    if (c2 == '·')
                        Console.Beep(650, 120);

                    else if (c2 == '—')
                        Console.Beep(650, 400);

                    else if (c2 == '/')
                        Thread.Sleep(500);
                }

                Console.WriteLine();
            }
        }
    }
}
