using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_RockPaperScissors.View
{
    class GameView
    {

        /// <summary>
        /// The game round variable
        /// </summary>
        public int gameRound = 1;


        /// <summary>
        /// Current date
        /// </summary>
        /// <returns></returns>
        private DateTime GetCurrentDateView()
        {
            DateTime date = DateTime.Now;
            return date;
        }

        /// <summary>
        /// Game titels
        /// </summary>
        /// <returns></returns>
        public void GameTitlesView()
        {
            Console.WriteLine("Console Game: \"Rock, Paper, Scissors\" " + GetCurrentDateView());
            Console.WriteLine();
        }

        /// <summary>
        /// Game round counter
        /// </summary>
        public void GameRound()
        {
            Console.WriteLine();
            Console.WriteLine($"Round № {gameRound++}");
            Console.WriteLine();
        }

        /// <summary>
        /// Show what player and computer choose to play
        /// </summary>
        /// <param name="player_choice"></param> 
        /// <param name="computer_choice"></param>
        public void PlayersChoiceView(string player_choice, string computer_choice)
        {
            Console.WriteLine();
            Console.WriteLine($"Player choise: {player_choice} ===== Computer choise {computer_choice}");
        }

        /// <summary>
        /// Show who win the round
        /// </summary>
        /// <param name="whoWinRound"></param>
        public void RoundResult(string whoWinRound)
        {
            Console.WriteLine(whoWinRound);
        }

        /// <summary>
        /// This method gets values of variables from GameController class that hold game score 
        /// </summary>
        /// <param name="player_score"></param> user points
        /// <param name="compyter_score"></param> compyter points
        public void GameScoreView(int player_score, int compyter_score)
        {            
            Console.WriteLine($"Player score: {player_score} ===== Computer score: {compyter_score}");
        }

        /// <summary>
        /// Show what final score and who win the game when user want to quit the game
        /// </summary>
        /// <param name="player_score"></param>
        /// <param name="computer_score"></param>
        public void GameFinalScore(int player_score, int computer_score)
        {
            
            Console.WriteLine("Finale score");
            Console.WriteLine($"Player score: {player_score} ===== Computer score: {computer_score}");
            if (player_score > computer_score)
            {
                Console.WriteLine("Player win the Game!");
            }
            else if (player_score < computer_score)
            {
                Console.WriteLine("Computer win the Game!");
            }
            else
            {
                Console.WriteLine("It\'s draw!");
            }
            
        }
    }
}
