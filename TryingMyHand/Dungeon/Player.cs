using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning.Dungeon
{
    public class Player
    {
        public static int playerLvl = 1;
        public string name = "";
        public int coins = 0;
        public int potion = 5;
        public int health = playerLvl * 12;
        public int damage = playerLvl * 5;
        public int armorValue = playerLvl * 6;
        public int weaponValue = 2;
        public string playerWeapon = "";
        public int playerExp = 0;
        public int toNextLevel = playerLvl * 100;
    }
}
