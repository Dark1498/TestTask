using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Server2.Models
{
    public class WordRepository
    {
        private List<Word> words = new List<Word>();
        // Репозиторий для 1 задания
        public WordRepository()
        {
            Add(new Word { Words = "Hello" });
        }

        public IEnumerable<Word> GetAll()
        {
            return words;
        }

        public Word Add(Word word)
        {
            words.Add(word);
            return word;
        }
        //Деление строки на массив
        public void WordsToArray(Word word)
        {
            string x = word.ToString();
            string[] Array = x.Split(new char[] { ' ' });
            for (int i = 0; i < Array.Length; i++)
            {
                Console.Write(Array[i] + " ");
            }
            Console.WriteLine();
        }

       
    }
}