using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning.Dungeon
{
    public class Enemies
    {
        public Dictionary<string, (string, int, int, string)> enemiesSmall;
        public Dictionary<string, (string, int, int, string)> enemiesMid;
        public Dictionary<string, (string, int, int, string)> enemiesLarge;
        public void SmallEnemyDict()
        {
            enemiesSmall = new Dictionary<string, (string, int, int, string)>();

            enemiesSmall.Add("Human Rogue", ("Human Rogue", 1, 5, "Rusty Dagger"));
            enemiesSmall.Add("Human Knight", ("Human Knight", 5, 10, "Steel Sword"));
            enemiesSmall.Add("Goblin", ("Goblin", 2, 6, "Club"));
            enemiesSmall.Add("Goblin Champion", ("Goblin Champion", 3, 8, "Spiked Club"));
            enemiesSmall.Add("Orc", ("Orc", 15, 20, "Iron Axe"));
            enemiesSmall.Add("Young Orc", ("Young Orc", 6, 15, "Bone Axe"));
            enemiesSmall.Add("Baby Dragon", (" Baby Dragon", 5, 25, "Weak Fire Breath"));

        }

        public void MidEnemyDict()
        {
            enemiesMid = new Dictionary<string, (string, int, int, string)>();

            enemiesMid.Add("", ("", 0, 0, ""));
            enemiesMid.Add("", ("", 0, 0, ""));
            enemiesMid.Add("", ("", 0, 0, ""));
            enemiesMid.Add("", ("", 0, 0, ""));
            enemiesMid.Add("", ("", 0, 0, ""));
            enemiesMid.Add("", ("", 0, 0, ""));
            enemiesMid.Add("", ("", 0, 0, ""));
        }

        public void LargeEnemyDict()
        {
            enemiesLarge = new Dictionary<string, (string, int, int, string)>();

            enemiesLarge.Add("", ("", 0, 0, ""));
            enemiesLarge.Add("", ("", 0, 0, ""));
            enemiesLarge.Add("", ("", 0, 0, ""));
            enemiesLarge.Add("", ("", 0, 0, ""));
            enemiesLarge.Add("", ("", 0, 0, ""));
            enemiesLarge.Add("", ("", 0, 0, ""));
            enemiesLarge.Add("Baby Dragon", ("Dragon", 5, 25, "Weak Fire Breath"));
        }

    }
}
