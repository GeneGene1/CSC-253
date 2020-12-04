/**
 * 9.19.20
 * CSC 253
 * Eugene Davis-Paulino
 * Creating a program that translate words into pig latin
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a sentence to translate to pig latin: ");
            string words = Console.ReadLine();
            var pigLatin = GetPigLatin(words);
            Console.WriteLine(pigLatin);
            Console.ReadLine();
        }

        public static string GetPigLatin(string words)
        {
            string letter = "Aa";
            var sentence = "";
            foreach (var word in words.Split())
            {
                var firstLetter = word.Substring(0, 1);
                var missingLetters = word.Substring(1, word.Length - 1);
                var currentLetter = letter.IndexOf(firstLetter);

                if (currentLetter==-1)
                {
                    sentence += missingLetters + firstLetter + "ay ";
                }
                else
                {
                    sentence += word + "ay ";
                }
            }
            return sentence;
        }
    }
}