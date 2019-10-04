using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_RockPaperScissors.View
{
    class GameView
    {
        private DateTime GetCurrentDateView()
        {
            DateTime date = DateTime.Now;
            return date;
        }
        public string GameTitlesView()
        {
            string title = "Console Game: \"Rock, Paper, Scissors\" " + GetCurrentDateView();
            return title;
        }

        /// <summary>
        /// In this method user can chose what to use in game or quit the game
        /// </summary>
        /// <returns></returns>
        public string ChoseWhatToUseView()
        {
            Console.WriteLine("Chose what you want to use:\n Rock (press 'r'),\n Paper (press 'p'),\n Scissors (press 's')");
            Console.WriteLine("To quit the game press 'q'");
            Console.Write("Write your choise here: ");
            string user_choise = Console.ReadLine().ToLower();
            switch (user_choise)
            {
                case "r":
                    return "Rock";
                case "p":
                    return "Paper";
                case "s":
                    return "Scissors";
                case "q":
                    return "quit";
                default:
                    return user_choise;
            }
        }

        public void RoundResultsView(string player_choise, string computer_choise)
        {
            Console.WriteLine($"Player choise: {player_choise} ===== Computer choise {computer_choise}");
            // TODO: add logic to "who win" view
            
        }

        public string GameScoreView()
        {
            //TODO: add view to game score
            return "game score";
        } 

        public void GameFinalScore(int player_score, int computer_score)
        {
            if (ChoseWhatToUseView() == "quit")
            {
                Console.WriteLine("Finale score");
                Console.WriteLine($"Player score: {player_score} ===== Computer score: {computer_score}");
                //TODO: add who win whole game
            }
        }
    }
}
