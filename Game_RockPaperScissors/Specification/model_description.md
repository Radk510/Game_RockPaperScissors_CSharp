## class: UserModel

### Methods

1. ChoseWhatToUse() - this method gets an apportunity to user to chose what to use: Rock, Paper or Scissors

1.1. **How it's works:** 
- In this method we print to console a question: Chose what you want to use: Rock (press 'r'), Paper (press 'p') or Scissors (press 's')
- In addition, user can chose to press 'q' to quit the game: **To quit the game press 'q'**
- User has an ability to enter his choise by using Console.ReadLine().ToLower() method.
- Then according to user choise in switch construction we decide what string to return
- Method returns the string with name of choise of with string that tells about user's wish to quit the game.

