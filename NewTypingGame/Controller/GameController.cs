using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewTypingGame.Model;
using NewTypingGame.View;

namespace NewTypingGame.Controller
{
    class GameController
    {
        ConsoleView _view = new ConsoleView();
        Sentence _sentence = new Sentence();
        SentenceDB _sentenceDb = new SentenceDB();
        public int Counter { get; set; }
        public int TotalMistakes { get; set; }
        public int TotalLength { get; set; }

        public GameController()
        {

        }

        public void StartGame()
        {
            _view.DisplayMenu();
            string choice = _view.WaitForInput();
            
            switch (choice)
            {
                case "1":
                    StartSentences(_sentence.Difficulty);
                    break;
                default:
                    break;
            }
        }

        public void StartSentences(int difficulty)
        {
            _view.Countdown();
            ResetCounters();
            TimeSpan startTimer = StartTimer();

            while (Counter < 5)
            {
                Line randomLine = _sentenceDb.GetRandomLine(difficulty);
                string randomSentence = randomLine.LineString;
                _view.DisplaySentence(randomSentence);
                string userLineInput = _view.WaitForInput();
                TotalMistakes += _sentence.CompareStrings(randomSentence, userLineInput);
                TotalLength += randomLine.LineLength;
                Counter++;
            }

            TimeSpan endTimer = EndTimer();
            _view.EndGameDisplay((endTimer - startTimer), TotalMistakes, TotalLength);
        }

        public void ResetCounters()
        {
            Counter = 0;
            TotalMistakes = 0;
            TotalLength = 0;
        }

        public TimeSpan StartTimer()
        {
            var now = DateTime.Now.TimeOfDay;
            return now;
        }

        public TimeSpan EndTimer()
        {
            var end = DateTime.Now.TimeOfDay;
            return end;
        }


    }
}
