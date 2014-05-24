using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTypingGame.View
{
    class ConsoleView
    {
        public void DisplayMenu()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine();
            Console.WriteLine("  |========================|");
            Console.WriteLine("  |          TYPO          |");
            Console.WriteLine("  |========================|");
            Console.WriteLine("  |  Enter your option     |");
            Console.WriteLine("  |                        |");
            Console.WriteLine("  |  1. NEW GAME           |");
            Console.WriteLine("  |  2. HIGHSCORE          |");
            Console.WriteLine("  |  3. DIFFICULITY        |");
            Console.WriteLine("  |                        |");
            Console.WriteLine("  |========================|");
            Console.ResetColor();
            Console.WriteLine();
            Console.Write(">> ");
        }

        public void EndGameDisplay(TimeSpan elapsedTime, int totalMistakes, int totalSentenceLength)
        {
            Console.WriteLine("Time elapsed:     " + (elapsedTime).Seconds + ":" + (elapsedTime).Milliseconds + " seconds");
            Console.WriteLine("Total Mistakes:   " + totalMistakes);
            Console.WriteLine("Words per minute: " + (int)(totalSentenceLength / FormatElapsedTime(elapsedTime)));
            Console.WriteLine("Press enter to go back to menu");
            Console.ReadLine();
        }

        public float FormatElapsedTime(TimeSpan elapsedTimeInput)
        {
            return (float)(elapsedTimeInput.Seconds / 60);
        }

        public string WaitForInput()
        {
            return Console.ReadLine();
        }

        public void DisplaySentence(string sentence)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(sentence);
            Console.Write(">> ");
            Console.ResetColor();
        }

        public void Countdown()
        {
            int countdown = 3;
            Console.WriteLine("{0}...", countdown);
            System.Threading.Thread.Sleep(1000);
            countdown--;
            Console.WriteLine("{0}...", countdown);
            System.Threading.Thread.Sleep(1000);
            countdown--;
            Console.WriteLine("{0}...", countdown);
            System.Threading.Thread.Sleep(1000);
            Console.Clear();
        }
    }
}
