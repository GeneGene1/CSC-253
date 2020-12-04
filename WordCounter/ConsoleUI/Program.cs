/**
 * 9.10.20
 * CSC 253
 * Eugene Davis-Paulino
 * Creating a program that calculates the number of words
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

            //string[] tokens = sentence.Split(null);

            total = WordCounter(sentence);

            Console.ReadLine();
        }
        public static int WordCounter(string sentence)
        {
            int numberOfWord = 0;

            string[] tokens = sentence.Split(null);
            Console.WriteLine(tokens.Length);

            //foreach (string letter in sentence)
            //{
            //    if (string.(letter))
            //    {
            //        numberOfWord++;
            //    }
            //}
            return numberOfWord;
        }

    }
}
