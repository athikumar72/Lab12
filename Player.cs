using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_number12
{
    public enum Roshambo { rock, paper, scissor, none }

    

    abstract class Player
    {
       

        public string playerName;
        public Roshambo roshamboValue;

        public void setPlayerName(string playername)
        {
            this.playerName = playerName;
        }

        public void setRoshamboValue(Roshambo roshamboValue)
        {
            this.roshamboValue = roshamboValue;
        }

        public string getPlayerName()
        {
            return playerName;
        }

        public Roshambo sgetRoshamboValue()
        {
            return roshamboValue;
        }

          

        public abstract  Roshambo generateRoshambo();
        
        

    }
}
