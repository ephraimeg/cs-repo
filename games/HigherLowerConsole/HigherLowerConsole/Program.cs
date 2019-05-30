using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HigherLowerConsole
{
    public class Program
    {
        protected int score;
        protected string player_name;
        private Random random_number_generator;

        const int LIMIT = 10;
        static void Main(string[] args)
        {
            Program HigherLower = new Program();
        }
        
        public Program()
        {
            random_number_generator = new Random();
            score = 0;
            this.Greeting();
            this.ShowInstructions();
            this.Play();
        }
        private void Greeting()
        {
            Console.Write(@"=======================================================================
=======================================================================
   _____                   _    _____ _          _ _ _         _   _ 
  |  _  |___ ___ _ _ ___ _| |  |_   _| |_ ___   | | | |___ ___| |_| |
  |     |  _| . | | |   | . |    | | |   | -_|  | | | | . |  _| | . |
  |__|__|_| |___|___|_|_|___|    |_| |_|_|___|  |_____|___|_| |_|___|

=======================================================================
=======================================================================

                    - a game of chance -

                  Enter your name: ");
            do
            {
                player_name = Logger.ReadLine();

            } while (player_name.Equals(String.Empty));
            player_name = player_name.Replace(" ", "_").ToLower();
        }
        private void ShowInstructions()
        {
            Console.WriteLine(String.Format(@"
Rules: 
    At the start of the game, you are given a number between 0 to {0}
    Guess whether the next number will be higher or lower or same
    A correct answer gives 5 points, and a wrong answer gives -3 points
    Quit anytime by entering (Q)uit instead of (H)igher, (L)ower or (S)ame
", LIMIT-1));
        }

        private void Play()
        {

            string input = "";
            int previous_number = random_number_generator.Next(LIMIT);
            int next_number = random_number_generator.Next(LIMIT);
            bool error = false;

            do
            {
                if(!error)
                    Logger.WriteLine($"\n    {previous_number}");

                error = false;
                Logger.Write($"    Your guess (higher/lower/same/quit): ");
                input = Logger.ReadLine();

                input = input.ToLower();
                if(input.Equals("higher") || input.Equals("h"))
                {
                    Logger.WriteLine($"    You guessed HIGHER the next number is: {next_number}");
                    if (next_number > previous_number)
                        Logger.WriteLine($"       Good Job! Current score is {this.PlusScore()}");
                    else
                        Logger.WriteLine($"       Sorry, current score is {this.MinusScore()}");
                }
                else if(input.Equals("lower") || input.Equals("l"))
                {
                    Logger.WriteLine($"    You guessed LOWER the next number is: {next_number}");
                    if (next_number < previous_number)
                        Logger.WriteLine($"       Good Job! Current score is {this.PlusScore()}");
                    else
                        Logger.WriteLine($"       Sorry, current score is {this.MinusScore()}");
                }
                else if(input.Equals("same") || input.Equals("s"))
                {
                    Logger.WriteLine($"    You guessed SAME the next number is: {next_number}");
                    if (next_number == previous_number)
                        Logger.WriteLine($"       Good Job! Current score is {this.PlusScore()}");
                    else
                        Logger.WriteLine($"       Sorry, current score is {this.MinusScore()}");
                }
                else if(input.Equals("quit") || input.Equals("q"))
                {
                    Logger.WriteLine($"       ... Exiting with {score} score");
                    Console.WriteLine($"       ... Saving log file");
                    Logger.SaveLog(true, "./.logs", $"{player_name}_log.txt");
                    Console.Write("Press any key to exit...");
                    Console.ReadKey();
                    break;
                }
                else
                {
                    error = true;
                    continue;
                }

                previous_number = next_number;
                next_number = random_number_generator.Next(LIMIT);
            } while (true);
        }

        private int PlusScore() { return score += 5; }
        private int MinusScore() { return score -= 3; }

    }
}
