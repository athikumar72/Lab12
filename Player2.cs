using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_number12
{
     class Player2 : Player

    {

      
        int value1 = 0;
        public string option = "";
        string option1 = Console.ReadLine();
        //  Player1 Player_obj = new Player1(option1);

       

        public override Roshambo generateRoshambo()
        {
            Random value = new Random();
          value1= value.Next(1,5);
            if( value1==1)
            {
                return roshamboValue = Roshambo.rock;
            }
            else  if(value1==2)
            { return roshamboValue = Roshambo.paper; }
            else  if (value1 == 3)
            { return roshamboValue = Roshambo.scissor; }
            else 
            
             return roshamboValue = Roshambo.none; 


        }












    }
}

