//Sebastian Bruce
//November 3rd, 2023
//Rock Paper Scissors

using System;

class Program
{
    static void Main()
    {
        //welcome message
        Console.WriteLine("Let's play Rock, Paper, Scissors!");

        while (true)
        {
            //ask for input
            Console.WriteLine("Choose: rock, paper, or scissors.");
            //read input
            string? input = Console.ReadLine();
            
            //check if user entered "null"
            //(this wasn't actually a problem because of the verification check but i was getting a warning when i ran)
            string? playerChoice = input != null ? input.ToLower() : "";

            //validate user input
            if (playerChoice != "rock" && playerChoice != "paper" && playerChoice != "scissors")
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

            //generate a random choice for the computer
            Random random = new Random();
            int computerChoice = random.Next(1, 4);

            string computerMove = "";

            //pick computers move based off the random number
            if (computerChoice == 1)
            {
                computerMove = "rock";
            }
            else if (computerChoice == 2)
            {
                computerMove = "paper";
            }
            else if (computerChoice == 3)
            {
                computerMove = "scissors";
            }

            //display the computer and user choices
            Console.WriteLine($"Computer chose: {computerMove}, You chose: {playerChoice}");

            //determine the winner and print who won
            if (playerChoice == computerMove)
            {
                Console.WriteLine("It's a tie");
            }
            else if ((playerChoice == "rock" && computerMove == "scissors") ||
                     (playerChoice == "paper" && computerMove == "rock") ||
                     (playerChoice == "scissors" && computerMove == "paper"))
            {
                Console.WriteLine("User Wins");
            }
            else
            {
                Console.WriteLine("Computer Wins");
            }

            //ask if user would like to replay
            Console.WriteLine("Would you like to play again? ('y' or 'n')");
            
            //declare variable which will be used to null check and store the input later
            string? playAgain = "";

            //this while loop is only needed in case user enters something invalid so it doesn't loop the whole code
            while (true) {
                //read user input
                string? input1 = Console.ReadLine();

                //check if user entered "null"
                //(this wasn't actually a problem because of verification check but i was getting a warning when i ran)
                playAgain = input1 != null ? input1.ToLower() : "";

                //validate user input
                if(playAgain == "y" || playAgain == "n") {
                    break; //break if input is valid
                }
                else {
                    Console.WriteLine("Invalid input. Please choose 'y' or 'n'"); 
                    continue; //loop if not
                }
            }
                if(playAgain == "y") {
                    continue; //play again if user wants
                }
                else {
                    Console.WriteLine("Thanks for Playing!");
                    break; //end if not
                }
        }
    }
}