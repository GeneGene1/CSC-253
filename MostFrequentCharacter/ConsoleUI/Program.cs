/**
 * 9.19.20
 * CSC 253
 * Eugene Davis-Paulino
 * Creating a program that show the most frequent letter
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
            string sentence;
            int[] letter = new int[255];
            int letters = 0;
            int max;
            int poll;
            int a;
            Console.WriteLine("Type the string: ");
            sentence = Console.ReadLine();

            poll = sentence.Length;

            for(letters=0; letters<255; letters++)
            {
                letter[letters] = 0;
            }
            letters = 0;

            while(letters<poll)
            {
                a = (int)sentence[letters];
                letter[a] += 1;
                letters++;
            }
            max = 0;

            for (letters=0; letters<255; letters++)
            {
                if (letters!= 16) 
                {
                    if (letter[letters] > letter[max])
                    max = letters;
                }
            }
            Console.WriteLine("The most letter is '{0}' which appears {1} times\n",(char)max,letter[max]);
            Console.ReadLine();
        }

    }
}
