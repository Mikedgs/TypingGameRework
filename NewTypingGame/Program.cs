using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NewTypingGame.Controller;

namespace NewTypingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            GameController _controller = new GameController();
            _controller.StartGame();
        }
    }
}
