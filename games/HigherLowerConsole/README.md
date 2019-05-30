# Around The World Game
----
...except you don't win cash

## User Interface

##### Console
```bash
=======================================================================
=======================================================================
   _____                   _    _____ _          _ _ _         _   _ 
  |  _  |___ ___ _ _ ___ _| |  |_   _| |_ ___   | | | |___ ___| |_| |
  |     |  _| . | | |   | . |    | | |   | -_|  | | | | . |  _| | . |
  |__|__|_| |___|___|_|_|___|    |_| |_|_|___|  |_____|___|_| |_|___|

=======================================================================
=======================================================================

                    - a game of chance -

                  Enter your name: player_name
Rules: 
    At the start of the game, you are given a number between 0 to {0}
    Guess whether the next number will be higher or lower or same
    A correct answer gives 5 points, and a wrong answer gives -3 points
    Quit anytime by entering (Q)uit instead of (H)igher, (L)ower or (S)ame

	{number}
	Your guess (higher/lower/same/quit): [h|higher|l|lower|s|same|q|quit]
	You guessed [HIGHER|LOWER|SAME] the next number is: {another_number}
		Sorry, current score is {current_score - deduction}
	
	{number}
	Your guess (higher/lower/same/quit): [h|higher|l|lower|s|same|q|quit]
	You guessed [HIGHER|LOWER|SAME] the next number is: {another_number}
		Good job! Current score is {current_score - merit}
		
	{number}
	Your guess (higher/lower/same/quit): [q|quit]
		... Exiting with {current_score} score
		... Saving log file
Press any key to exit...
```

##### Generated Log _(player_name.txt)_
```
player_name

    4
    Your guess (higher/lower/same/quit): h
    You guessed HIGHER the next number is: 3
       Sorry, current score is -3

    3
    Your guess (higher/lower/same/quit): h
    You guessed HIGHER the next number is: 1
       Sorry, current score is -6

    1
    Your guess (higher/lower/same/quit): h
    You guessed HIGHER the next number is: 2
       Good Job! Current score is -1

    2
    Your guess (higher/lower/same/quit): q
       ... Exiting with -1 score
The log above is dated: 5/30/2019 3:47:53 PM
```