using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Morsekode
{
    /// <summary>
    /// A morsecode handler that can convert letters, numbers, spaces and combinations of these into morsecode.
    /// can also play the morsecode using console.beep method.
    /// </summary>
    public class MorseHandler
    {
        /// <summary>
        /// Simple dictionary with key,value pairs of key(letter/number) and value(morse equivelant)
        /// </summary>
        private static Dictionary<string, string> MORSEDICTIONARY = new Dictionary<string, string>(){
        {" ","/"},{"A","·—"},{"B","—···"},{"C","—·—·"},{"D","—··"},{"E","·"},{"F","··—·"},{"G","——·"},{"H","····"},{"I","··"},
        {"J","·———"},{"K","—·—"},{"L","·—··"},{"M","——"},{"N","—·"},{"O","———"},{"P","·——·"},{"Q","——·—"},{"R","·—·"},{"S","···"},
        {"T","—"},{"U","··—"},{"V","···—"},{"W","·——"},{"X","—··—"},{"Y","—·——"},{"Z","——··"},{"Æ","·—·—"},{"Ø","———·"},{"Å","·——·—"},
        {"1","·————"},{"2","··———"},{"3","···——"},{"4","·····"},{"5","····—"},{"6","—····"},{"7","——···"},{"8","———··"},{"9","————"},{"0","—————"},
        };
        /// <summary>
        /// Will convert and return a sentence of letters and numbers into morse
        /// </summary>
        /// <param name="sentence">should be typeof string, but can contain any letter, spaces and numbers, will throw error on special characters</param>
        /// <returns>string of morsecode</returns>
        public string convertToMorse(string sentence)
        {
            var beep = string.Empty;
            foreach (char letterOrNumber in sentence)
            {
                try
                {
                    beep += MORSEDICTIONARY[letterOrNumber.ToString()];
                }
                catch (Exception)
                {

                    throw new ArgumentException("Please no special characters in the input sentence");
                }
                
            }
            return beep;
        }
        /// <summary>
        /// plays a morsecode sentence, e.g "hi you" in morse "······ —·—————··—"
        /// </summary>
        /// <param name="morseSentence"> should contain morsecode in string format, e.g "hi you" in morse "······ —·—————··—" </param>
        public void playMorse(string morseSentence)
        {
            foreach (char morseSymbol in morseSentence)
            {
                switch (morseSymbol)
                {
                    case '·':
                        Console.Beep(650, 120);
                        break;
                    case '—':
                        Console.Beep(650, 400);
                        break;
                    case '/':

                        Thread.Sleep(500);
                        break;

                    default:
                        break;
                }
            }
        }
    }
}
