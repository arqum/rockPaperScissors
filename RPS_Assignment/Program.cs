using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace RPS_Assignment
{
    class Program
    {
        public static int p1 = 0;
        public static int p2 = 0;


        static void Main(string[] args)
        {


            int counter = 1;
 
            Console.WriteLine("\n Press ESC to Exit :)");
            Console.WriteLine("\n ********Welcome to the Fun Olympics with only one game********");
           
            do
            {
       
                //create Player Class object
                Player player = new Player();
                Core core = new Core();

                Console.WriteLine("Game " + counter);
                Console.WriteLine("\n\n Scores:\n Player1: " + p1 + "\n\n Scores:\n Player2: " + p2);
                if (p1 == 2)
                {
                    Console.WriteLine("********CONGRAT Player 1. YOU WIN!!!!*********");
                    Thread.Sleep(3000);    

                    Environment.Exit(0);
                }
                else if(p2==2)
                {
                    Console.WriteLine("********CONGRAT Player 1. YOU WIN!!!!*********");
                    Thread.Sleep(3000);    

                    Environment.Exit(0);
                }


                Console.WriteLine("\n Please select Player 1 by entering:\n \n 1 = HUMAN \n 2 = Random Computer \n 3 = Super Quantum Computer \n \n and pressing ENTER");
                //get input for player type
                String P1Type = Console.ReadLine();
                //call method to determine player type
                var player1_Type = player.DeterminePlayer("Player 1", P1Type);              



                Console.WriteLine("\n Please select Player 2 by entering:\n \n 1 = HUMAN \n 2 = Random Computer \n 3 = Super Quantum Computer \n \n and pressing ENTER");
                String p2Type = Console.ReadLine();
                var player2_Type = player.DeterminePlayer("Player 2", p2Type);


                //get input for player 1 selection
                if (player1_Type == "Human")
                {

                   
                    //call method to relay player selection to the method with player, selection and type
                    player.PlayerSelection("Player 1", player1_Type);
                }
                else
                {
                    //call method to relay player selection to the method with player, selection and type
                    player.PlayerSelection("Player 1", player1_Type);

                }



                if (player2_Type == "Human")
                {
                    player.PlayerSelection("Player 2", player2_Type);

                }
                else
                {
                    player.PlayerSelection("Player 2", player2_Type);

                }


                counter++;
            } while (Console.ReadKey(true).Key != ConsoleKey.Escape || (counter < 3));




        }





    }
}
