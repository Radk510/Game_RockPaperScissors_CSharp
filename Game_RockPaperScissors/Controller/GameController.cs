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
        UserModel gameView = new UserModel();
        ComputerModel computerModel = new ComputerModel();

        /// <summary>
        /// Game score
        /// </summary>
        public int player_score = 0;
        public int computer_score = 0;

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
        
        /// <summary>
        /// Here values in score variables increased
        /// </summary>
        /// <returns></returns>
        public int ScoreIncrease()
        {
            if (WhoWinRound() == "Player win")
            {
                return player_score++;
            }
            else if (WhoWinRound() == "Computer win")
            {
                return computer_score++;
            }
            else if (WhoWinRound() == "Draw")
            {
                return 0;
            }
            else
            {
                return 0;
            }

            
        }
    }
}
