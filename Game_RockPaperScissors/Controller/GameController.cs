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
        /// <summary>
        /// Game score
        /// </summary>
        public int player_score = 0;
        public int computer_score = 0;

        /// <summary>
        /// Main operation where programm decide who win
        /// </summary>
        /// <returns></returns> 
        
        public void QuitGame(string user_choice)
        {
            if (user_choice == "quit")
            {
                gameView.GameFinalScore(player_score, computer_score);
            }
        } 
        public string WhoWinRound(string player_choice, string computer_choice)
        {
            if (
                (player_choice == "Rock" && computer_choice == "Scissors") ||
                (player_choice == "Scissors" && computer_choice == "Paper") ||
                (player_choice == "Paper" && computer_choice == "Rock")
               )
            {
                player_score++;
                return "Player win";
            }
            else if (
                     (player_choice == "Scissors" && computer_choice == "Rock") ||
                     (player_choice == "Paper" && computer_choice == "Scissors") ||
                     (player_choice == "Rock" && computer_choice == "Paper")
                    )
            {
                computer_score++;
                return "Computer win";
            }
            else
            {
                return "Draw";
            }
        }   
    }
}
