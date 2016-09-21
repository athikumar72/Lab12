using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_number12
{

    public class RoshamboApp
    {

     public   static void Main(string[] args)
        {
            string consolePlayerName = "";
            string playerOption = "";
            Roshambo selectedItem = 0;
            string selectedValue = "";
            Roshambo player1value = 0;
            Console.WriteLine("Welcome to Rock Paper Scissors!");
            Console.WriteLine($"Enter your name:  ");
            consolePlayerName = Console.ReadLine();
            Player Thejets = new Player1();
            Player TheSharks = new Player2();
            playerOption = Console.ReadLine();

            selectedValue = Console.ReadLine();
           
            Console.WriteLine("Would you like to play against Thejets or TheSharks(j/s)?");
            if (playerOption == "j")
            {
                Thejets.setPlayerName("Thejets");
                player1value = Thejets.generateRoshambo();
                Console.WriteLine("Rock,Paper,scissors?(R/P/S):");

                selectedItem = RoshamboApp.assignRoshamboValue(Console.ReadLine());
                if (selectedItem == Roshambo.rock)
                {
                    Console.WriteLine(" Draw");
                }
                else

                       if (selectedItem == Roshambo.scissor)
                    Console.WriteLine("consolePlyer Loss");
            }
            else
            { Console.WriteLine("Console player win");
            }
                    

            



            else if (playerOption == "s")
            {
                TheSharks.setPlayerName("The Sharks");

            }

            Console.WriteLine($"{ consolePlayerName} :{selectedItem}");
            Console.WriteLine($"{ } :{selectedItem}");

            //if (selectedItem ==)




        }


        public static Roshambo assignRoshamboValue(string selectedValue)
        {

            if (selectedValue == "r")
            {
                return Roshambo.rock;
            }
            else if (selectedValue == "p")

            {
                return Roshambo.paper;

            }
            else if (selectedValue == "s")

            {
                return Roshambo.scissor;
            }
            else
                return Roshambo.none;
        }



    }
}
