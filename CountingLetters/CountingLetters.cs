﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CountingLetters
{
    class CountingLetters
    {
        static void Main(string[] args)
        {

            string example = "Ala ma kota a kot ma mysz a mysz ma ser";

            var p = new CountingLetters();
            var result = p.LetterCounter(example);
            p.PrintResult(result);
        }

        public Dictionary<char, int> LetterCounter(string text)
        {
            Dictionary<char, int> counter = new Dictionary<char, int>();
            char[] charList = text.Where(ch => !Char.IsWhiteSpace(ch)).ToArray<char>();
            foreach (char ch in charList)
            {
                if (!counter.ContainsKey(ch))
                {
                    counter.Add(ch, 1);
                }
                counter[ch] += 1;
            }
            return counter;
        }

        public void PrintResult(Dictionary<char, int> counted)
        { 
            foreach (var item in counted)
            {
                Console.WriteLine(item.Key + " => " + item.Value);
            }
            Console.ReadKey();
        }
    }
}
