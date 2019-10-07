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
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Console Game: \"Rock, Paper, Scissors\" " + GetCurrentDateView());
            Console.WriteLine();
            Console.ResetColor();

        }

        /// <summary>
        /// Game round counter
        /// </summary>
        public void GameRound()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"\nRound № {gameRound++}\n");
            Console.ResetColor();
        }

        /// <summary>
        /// Show what player and computer choose to play
        /// </summary>
        /// <param name="player_choice"></param> 
        /// <param name="computer_choice"></param>
        public void PlayersChoiceView(string player_choice, string computer_choice)
        {            
            Console.WriteLine($"\n\nPlayer choise: {player_choice} ///// Computer choise: {computer_choice}\n");
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
            Console.WriteLine($"Player score: {player_score} <=====> Computer score: {compyter_score}");
        }

        public void EndOfRoundView()
        {
            String bottomLine = new String('=', Console.WindowWidth);
            Console.WriteLine(bottomLine);
        }

        /// <summary>
        /// Show what final score and who win the game when user want to quit the game
        /// </summary>
        /// <param name="player_score"></param>
        /// <param name="computer_score"></param>
        public void GameFinalScore(int player_score, int computer_score)
        {
            Console.BackgroundColor = ConsoleColor.DarkGreen;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("\n\nFinale score\n");
            Console.ResetColor();
            Console.WriteLine($"Player score: {player_score} <=====> Computer score: {computer_score}");
            if (player_score > computer_score)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("Player win the Game!");
                Console.ResetColor();
            }
            else if (player_score < computer_score)
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Computer win the Game!");
                Console.ResetColor();
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("It\'s draw!");
                Console.ResetColor();
            }

        }
    }
}
