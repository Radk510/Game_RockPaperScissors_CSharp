using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Game_RockPaperScissors.Controller;
using Game_RockPaperScissors.Model;
using Game_RockPaperScissors.View;

namespace Game_RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            GameView gameView = new GameView();
            UserModel userModel = new UserModel();
            ComputerModel computerModel = new ComputerModel();
            GameController gameController = new GameController();

            gameView.GameTitlesView();

            gameView.GameRound();
            string player_choice = userModel.PlayerChoice();
            string computer_choice = computerModel.ComputerChoice();
            string whoWin = gameController.WhoWinRound(player_choice, computer_choice);
            gameView.PlayersChoiceView(player_choice, computer_choice);
            gameView.RoundResult(whoWin);
            gameView.GameScoreView(gameController.player_score, gameController.computer_score);



        }
    }
}
