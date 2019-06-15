using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;


namespace HW5
{
    static class Message
    {

        private static string[] TextSeparator(string text)
        {
            char[] charSeparators = new char[] { '/', ',', '.', '!', ' ', '?', ':', ';' };
            string[] wordInString = text.Split(charSeparators, StringSplitOptions.RemoveEmptyEntries);
            return wordInString;
        }

        public static void onlyDefiniteWordLength(string text, int worfLength)
        {
            string[] wordInString = TextSeparator(text);

            for (int i = 0; i < wordInString.Length; i++)
            {
                if (wordInString[i].Length <= worfLength)
                {
                    Console.WriteLine(wordInString[i]);
                }
            }
        }

        public static void deletingWordFromText(ref string text, char badChar)
        {
            string[] wordInString = TextSeparator(text);
            ArrayList tmp = new ArrayList();

            for (int i = 0; i < wordInString.Length; i++)
            {
                if (wordInString[i].EndsWith(badChar.ToString()))
                {
                    tmp.Add(wordInString[i]);
                }
            }
            foreach (string item in tmp)
            {
                text = text.Replace(item, "");
            }
        }

        public static void longestWords(string text)
        {
            int length = 0;
            ArrayList longestWords = new ArrayList();

            string[] wordInString = TextSeparator(text);

            for (int i = 0; i < wordInString.Length; i++)
            {
                if (wordInString[i].Length > length) length = wordInString[i].Length;
            }

            for (int i = 0; i < wordInString.Length; i++)
            {
                if (wordInString[i].Length == length)
                {
                    longestWords.Add(wordInString[i]);
                }
            }

            StringBuilder sb = new StringBuilder();

            foreach (string word in longestWords)
            {
                sb.Append(word + " ");
            }
            Console.WriteLine(sb.ToString());
        }

        public static void showWordsDuplication(string[] words, string text)
        {
            Dictionary<string, int> doubles = new Dictionary<string, int>();
            string[] wordInString = TextSeparator(text);
            for (int i = 0; i < words.Length; i++)
            {
                int count = 0;
                for (int j = 0; j < wordInString.Length; j++)
                {
                    if (wordInString[j].Equals(words[i]))
                    {
                        count++;
                    }
                }
                doubles.Add(words[i], count);
            }
            foreach (KeyValuePair<string, int> item in doubles)
            {
                Console.WriteLine($"Количество повторения слова {item.Key} в тексте равно {item.Value}.");
            }
        }


    }
}
