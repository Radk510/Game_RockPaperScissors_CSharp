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
        /// Number of game round
        /// </summary>
        public void GameRound()
        {
            Console.WriteLine();
            int number = 1;
            Console.WriteLine($"Round № {number++}");
            Console.WriteLine();
        }

        /// <summary>
        /// What player and computer choose to play
        /// </summary>
        /// <param name="player_choice"></param> 
        /// <param name="computer_choice"></param>
        public void PlayersChoiceView(string player_choice, string computer_choice)
        {
            Console.WriteLine();
            Console.WriteLine($"Player choise: {player_choice} ===== Computer choise {computer_choice}");
        }

        /// <summary>
        /// Who win the round
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

        //public void GameFinalScore(int player_score, int computer_score)
        //{
        //    if (PlayerChoice() == "quit")
        //    {
        //        Console.WriteLine("Finale score");
        //        Console.WriteLine($"Player score: {player_score} ===== Computer score: {computer_score}");
        //        //TODO: add who win whole game
        //    }
        //}
    }
}
