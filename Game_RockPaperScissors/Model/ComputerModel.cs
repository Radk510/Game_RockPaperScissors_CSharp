using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_RockPaperScissors.Model
{
    class ComputerModel
    {
        Random random = new Random();
        private enum WhatToUse
        {
            Rock,
            Paper,
            Scissors
        }

        public string ComputerChoice()
        {
            string computer_choice = "";
            switch (random.Next(0, 3))
            {
                case 0:
                    computer_choice = WhatToUse.Rock.ToString();
                    break;
                case 1:
                    computer_choice = WhatToUse.Paper.ToString();
                    break;
                case 2:
                    computer_choice = WhatToUse.Scissors.ToString();
                    break;
            }
            return computer_choice;
        }
    }
}
