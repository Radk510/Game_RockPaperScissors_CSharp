using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_RockPaperScissors.View;

namespace Game_RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            GameView gameView = new GameView();

            Console.WriteLine(gameView.GameTitlesView());
            Console.WriteLine(gameView.ChoseWhatToUseView());
        }
    }
}
