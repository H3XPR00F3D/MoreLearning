using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning.Dungeon
{
    public class Enemies
    {
       public Dictionary<string, (string, int, int, string)> enemies;
        public void EnemyDict()
        {
            enemies = new Dictionary<string, (string, int, int, string)>();

            enemies.Add("Human Rogue", ("Human Rogue", 1, 5, "Rusty Dagger"));
            enemies.Add("Human Knight", ("Human Knight", 5, 10, "Steel Sword"));
            enemies.Add("Goblin", ("Goblin", 2, 6, "Club"));
            enemies.Add("Goblin Champion", ("Goblin Champion", 3, 8, "Spiked Club"));
            enemies.Add("Orc", ("Orc", 15, 20, "Iron Axe"));
            enemies.Add("Young Orc", ("Young Orc", 6, 15, "Bone Axe"));
            enemies.Add("Dragon", ("Dragon", 20, 25, "Fire Breath"));

        }
    }

}
