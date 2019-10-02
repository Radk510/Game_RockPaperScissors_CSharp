using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_RockPaperScissors
{
    class UserModel
    {
        /// <summary>
        /// In this method user can chose what to use in game or quit the game
        /// </summary>
        /// <returns></returns>
        public string ChoseWhatToUse()
        {
            Console.WriteLine("Chose what you want to use: Rock (press 'r'), Paper (press 'p') or Scissors (press 's')");
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
        
    }
}
