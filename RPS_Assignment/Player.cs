using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPS_Assignment
{
    class Player
    {
        string[] selections = new string[2];
        string[] types = new string[2];
        bool super;



        public string DeterminePlayer(String Player, String type)
        {

            switch (type)
            {
                case "1":
                    Console.WriteLine(Player + " is a Human");
                    return "Human";

                case "2":
                    Console.WriteLine(Player + " is a Random Computer");
                    return "Random";
                case "3":
                    Console.WriteLine(Player + " is a Super Quantum Computer");

                    return "Super";


                default:
                    return "nothing";
                //Code
            }

        }





        public void PlayerSelection(String Player, string type)
        {


            Core core = new Core();

           

                if (type == "Human" && Player == "Player 1")
                {

                    Console.WriteLine("\n PLAYER 1: Please select rock, paper or scissors and press ENTER");
                    selections[0] = Console.ReadLine();

                    switch (selections[0])
                    {
                        case "rock":
                            Console.WriteLine(Player + " selected rock");
                            break;
                        case "paper":
                            Console.WriteLine(Player + " selected paper");
                            break;
                        case "scissors":
                            Console.WriteLine(Player + " selected scissors");

                            break;
                        default:
                            //Code
                            break;
                    }


                }

                else if (type == "Human" && Player == "Player 2")
                {

                    Console.WriteLine("\n PLAYER 2: Please select rock, paper or scissors and press ENTER");
                    selections[1] = Console.ReadLine();

                    switch (selections[1])
                    {
                        case "rock":
                            Console.WriteLine(Player + " selected rock");
                            break;
                        case "paper":
                            Console.WriteLine(Player + " selected paper");
                            break;
                        case "scissors":
                            Console.WriteLine(Player + " selected scissors");

                            break;
                        default:
                            //Code
                            break;
                    }
                    core.GameEngine(selections[0], selections[1]);




                }

                else if (type == "Random" && Player == "Player 1")
                {
                    //core.GameEngine();
                    selections[0] = core.RandomGenerator();
                    Console.WriteLine(Player + " has selected " + selections[0]);
                }
                else if (type == "Random" && Player == "Player 2")
                {

                    selections[1] = core.RandomGenerator();
                    Console.WriteLine(Player + " has selected " + selections[1]);
                    core.GameEngine(selections[0], selections[1]);


                }
                else if (type == "Super" && Player == "Player 1")
                {
                    //core.GameEngine();
                    selections[0] = core.RandomGenerator();
                    Console.WriteLine(Player + " has selected " + selections[0]);
                    types[0] = "Super";

                }
                else if (type == "Super" && Player == "Player 2")
                {

                    selections[1] = core.RandomGenerator();
                    Console.WriteLine(Player + " has selected " + selections[1]);
                    types[1] = "Super";
                    core.GameEngine(selections[0], selections[1], types[0], types[1]);


                }


            

        }


    }


}
