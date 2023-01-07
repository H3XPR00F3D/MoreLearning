using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning.Dungeon
{
        //Anything concerning encounter text.
        public class PlayerRecords
        {
         
            public static void PlayerLvlExp()
            {
                PromptPrint.text = ("   Lvl: " +  Player.playerLvl + "     Exp: " + Engine.currentPlayer.playerExp+"\n");
                PromptPrint.Print();
            }

            public static void PlayerInventory()
            {
                PromptPrint.text = ("  Potions: " + Engine.currentPlayer.potion + " Health: " + Engine.currentPlayer.health + "\n");
                PromptPrint.Print();
            }
        }
}
