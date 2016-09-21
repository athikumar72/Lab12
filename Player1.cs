using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_number12
{
     class Player1: Player
    {
        //String playerName = "";
        int roshamboValue2 = 0;
        int value = 0;
        public string option = "";
        string option1 = Console.ReadLine();

       // string rock = Roshambo_Enum.rock.ToString();
       
             public override Roshambo generateRoshambo()
        {


         return   Roshambo.rock;
           // Random value = new Random();
         // return roshamboValue = (Roshambo) value.Next(1, 1);


        }

       
    }
    }
