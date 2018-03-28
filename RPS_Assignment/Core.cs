using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Assignment
{
    class Core
    {
        private static string lastSelection = "";
        public string RandomGenerator()
        {
            string[] selectionsRepo = new string[3];
            selectionsRepo[0] = "rock";
            selectionsRepo[1] = "paper";
            selectionsRepo[2] = "scissors";


            Random random = new Random();
            int randSelection = random.Next(selectionsRepo.Length);


            return selectionsRepo[randSelection];

        }

        public void GameEngine(string p1_selection, string p2_selection)
        {
            // to keep the code DRY
            CoreLogic(p1_selection, p2_selection);

        }

        //overload for Super Quantum
        public void GameEngine(string p1_selection, string p2_selection, string player_1, string player_2)
        {
            if (lastSelection == "")
            {
                var currentSelection = p1_selection;
                lastSelection = currentSelection;

            }

            Console.WriteLine("last selection  " + lastSelection);

            if (player_1 != null && player_1 == "Super")
            {
                var player = 1;
                // to keep the code DRY
                CoreLogic(p1_selection, p2_selection, lastSelection, player);

            }
            else if (player_2 != null && player_2 == "Super")
            {
                var player = 2;
                // to keep the code DRY
                CoreLogic(p1_selection, p2_selection, lastSelection, player);
            }


        }


        public void CoreLogic(string p1_selection, string p2_selection)
        {

            if (p1_selection == "rock" && p2_selection == "scissors")
            {

                Console.WriteLine("\n\n******** Rock beats Scissors! ******** \n Player 1 wins this round.");

                //counting wins
                Program.p1 = Program.p1 + 1;


            }
            if (p2_selection == "rock" && p1_selection == "scissors")
            {

                Console.WriteLine("\n\n******** Rock beats Scissors! ******** \n Player 2 wins this round.");
                Program.p2 = Program.p2 + 1;
            }
            else if (p1_selection == "scissors" && p2_selection == "paper")
            {

                Console.WriteLine("\n\n******** Scissors beats Paper! ******** \n Player 1 wins this round.");
                Program.p1 = Program.p1 + 1;
            }
            else if (p2_selection == "scissors" && p1_selection == "paper")
            {

                Console.WriteLine("\n\n******** Scissors beats Paper! ******** \n Player 2 wins this round.");
                Program.p2 = Program.p2 + 1;
            }
            else if (p1_selection == "paper" && p2_selection == "rock")
            {

                Console.WriteLine("\n\n******** Paper beats rock! ******** \n Player 1 wins this round.");
                Program.p1 = Program.p1 + 1;
            }
            else if (p2_selection == "paper" && p1_selection == "rock")
            {

                Console.WriteLine("\n\n******** Paper beats rock! ******** \n Player 2 wins this round.");
                Program.p2 = Program.p2 + 1;
            }

            else if (p1_selection == p2_selection)
            {
                Console.WriteLine("\n\n******** OOPS! ******** \n Same selections...");


            }

        }

        public void CoreLogic(string p1_selection, string p2_selection, string lastSelection, int player)
        {

            switch (player)
            {
                case 1:
                    p1_reverseLastAction(lastSelection, p1_selection);

                    break;
                case 2:
                    p2_reverseLastAction(lastSelection, p2_selection);

                    break;
            }


            if (lastSelection == "rock" && p2_selection == "scissors")
            {

                Console.WriteLine("\n\n******** Rock beats Scissors! ******** \n Player 1 wins this round.");
                Program.p1 = Program.p1 + 1;
                
            }
            if (p2_selection == "rock" && lastSelection == "scissors")
            {

                Console.WriteLine("\n\n******** Rock beats Scissors! ******** \n Player 2 wins this round.");
                Program.p2 = Program.p2 + 1;
            }
            else if (lastSelection == "scissors" && p2_selection == "paper")
            {

                Console.WriteLine("\n\n******** Scissors beats Paper! ******** \n Player 1 wins this round.");
                Program.p1 = Program.p1 + 1;
            }
            else if (p2_selection == "scissors" && lastSelection == "paper")
            {

                Console.WriteLine("\n\n******** Scissors beats Paper! ******** \n Player 2 wins this round.");
                Program.p2 = Program.p2 + 1;
            }
            else if (lastSelection == "paper" && p2_selection == "rock")
            {

                Console.WriteLine("\n\n******** Paper beats rock! ******** \n Player 1 wins this round.");
                Program.p1 = Program.p1 + 1;
            }
            else if (p2_selection == "paper" && lastSelection == "rock")
            {

                Console.WriteLine("\n\n******** Paper beats rock! ******** \n Player 2 wins this round.");
                Program.p2 = Program.p2 + 1;
            }

            else if (lastSelection == p2_selection)
            {
                Console.WriteLine("\n\n******** OOPS! ******** \n Same selections...");


            }

        }

        
        private void p1_reverseLastAction(string lastSelection, string p1_selection)
        {
            if (lastSelection == "rock")
            {

                p1_selection = "paper";
            }
            else if (lastSelection == "paper")
            {
                p1_selection = "scissors";
            }
            else if (lastSelection == "scissors")
            {

                p1_selection = "rock";
            }

        }

        private void p2_reverseLastAction(string lastSelection, string p2_selection)
        {
            if (lastSelection == "rock")
            {

                p2_selection = "paper";
            }
            else if (lastSelection == "paper")
            {
                p2_selection = "scissors";
            }
            else if (lastSelection == "scissors")
            {

                p2_selection = "rock";
            }

        }


    }


}
