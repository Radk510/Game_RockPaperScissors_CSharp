using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_RockPaperScissors.Model;
using Game_RockPaperScissors.View;

namespace Game_RockPaperScissors.Controller
{
    class GameController
    {
        GameView gameView = new GameView();
        ComputerModel computerModel = new ComputerModel();

        /// <summary>
        /// Game score
        /// </summary>
        private int player_score = 0;
        private int computer_score = 0;

        /// <summary>
        /// Main operation where programm decide who win
        /// </summary>
        /// <returns></returns>
        public string WhoWinRound()
        {
            if (
                (gameView.PlayerChoice() == "Rock" && computerModel.ComputerChoice() == "Scissors") ||
                (gameView.PlayerChoice() == "Scissors" && computerModel.ComputerChoice() == "Paper") ||
                (gameView.PlayerChoice() == "Paper" && computerModel.ComputerChoice() == "Rock")
               )
            {
                return "Player win";
            }
            else if (
                     (gameView.PlayerChoice() == "Scissors" && computerModel.ComputerChoice() == "Rock") ||
                     (gameView.PlayerChoice() == "Paper" && computerModel.ComputerChoice() == "Scissors") ||
                     (gameView.PlayerChoice() == "Rock" && computerModel.ComputerChoice() == "Paper")
                    )
            {
                return "Computer win";
            }
            else
            {
                return "Draw";
            }
        }       
    }
}
