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
        public string PlayerChoice()
        {
            Console.WriteLine("Chose what you want to use:\n Rock (press 'r'),\n Paper (press 'p'),\n Scissors (press 's')");
            Console.WriteLine("To quit the game press 'q'");
            Console.Write("Write your choise here: ");
            string user_choice = Console.ReadLine().ToLower();
            bool wrongUserChoice = false;
            if (user_choice != "r" && user_choice != "p" && user_choice != "s" && user_choice != "q")
            {
                wrongUserChoice = true;
            }
            while (wrongUserChoice)
            {
                Console.Write("Type your choice again: ");
                user_choice = Console.ReadLine().ToLower();
                if (user_choice == "r" || user_choice == "p" || user_choice == "s" || user_choice == "q")
                {
                    wrongUserChoice = false;
                }
            }
            switch (user_choice)
            {
                case "r":
                    user_choice = "Rock";
                    break;
                case "p":
                    user_choice = "Paper";
                    break;
                case "s":
                    user_choice = "Scissors";
                    break;
                case "q":
                    user_choice = "quit";
                    break;
                default:
                    return user_choice;
            }
            return user_choice;
        }
    }
}
