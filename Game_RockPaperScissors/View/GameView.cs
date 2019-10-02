using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_RockPaperScissors.View
{
    class GameView
    {
        private DateTime GetCurrentDate()
        {
            DateTime date = DateTime.Now;
            return date;
        }
        public string GameTitles()
        {
            string title = "Console Game: \"Rock, Paper, Scissors\" " + GetCurrentDate();
            return title;
        }

        
    }
}
