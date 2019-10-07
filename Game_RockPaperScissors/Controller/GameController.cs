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
        /// <summary>
        /// Game score
        /// </summary>
        public int player_score = 0;
        public int computer_score = 0;

        /// <summary>
        /// Main operation where programm decide who win
        /// </summary>
        /// <returns></returns> 
        
        
            

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

        
        /// <summary>
        /// Here values in score variables increased
        /// </summary>
        /// <returns></returns>
        //public int ScoreIncrease()
        //{
        //    if (WhoWinRound() == "Player win")
        //    {
        //        return player_score++;
        //    }
        //    else if (WhoWinRound() == "Computer win")
        //    {
        //        return computer_score++;
        //    }
        //    else if (WhoWinRound() == "Draw")
        //    {
        //        return 0;
        //    }
        //    else
        //    {
        //        return 0;
        //    }
        //}
    }
}
