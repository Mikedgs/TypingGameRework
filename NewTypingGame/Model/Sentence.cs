using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTypingGame.Model
{
    class Sentence
    {
        public int Difficulty { get; set; }

        public Sentence()
        {
            Difficulty = 1;
        }

        public int CompareStrings(string sentenceFromDb, string sentenceFromUser)
        {
            string[] sentenceFromDbArray = sentenceFromDb.Split(' ');
            string[] sentenceArrayInput = sentenceFromUser.Split(' ');
            int countMistakes = 0;

            for (int i = 0; i < sentenceArrayInput.Length; i++)
            {
                if (sentenceArrayInput[i] != sentenceFromDbArray[i])
                {
                    countMistakes++;
                }
            }

            return countMistakes + (sentenceFromDbArray.Length - sentenceArrayInput.Length);
        }
    }
}
