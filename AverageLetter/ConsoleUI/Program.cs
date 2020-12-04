/**
 * 9.13.20
 * CSC 253
 * Eugene Davis-Paulino
 * Creating a program that calculates the average number of letters
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string sentence = "Four score and seven years ago";
            int total;

            total = WordCounter(sentence);

            Console.WriteLine(total);
            Console.ReadLine();
        }
        public static int WordCounter(string sentence)
        {
            int numberOfWord = 0;
            int average = 0;

            foreach (char letter in sentence)
            {
                if (char.IsLetter(letter))
                {
                    numberOfWord++;
                }
                string[] tokens = sentence.Split(null);
                average = numberOfWord / tokens.Length;
            }
            return average;
        }
    }
}
