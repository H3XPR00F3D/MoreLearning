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

            enemiesSmall.Add("Gizmo",("Gizmo",5,14,"Poisoned Daggers"));
            enemiesSmall.Add("Satyr",("Satyr",8,19,"Scimitars"));
            enemiesSmall.Add("Naiad",("Naiad",10,24,"Water Orbs"));
            enemiesSmall.Add("Salamander",("Salamander",12,29,"Fire Blades"));
            enemiesSmall.Add("Brownie",("Brownie",14,34,"Large Hammer"));
            enemiesSmall.Add("Nymph",("Nymph",15,39,"Slingshots"));
            enemiesSmall.Add("Dryad",("Dryad",18,44,"Wooden Clubs"));
            enemiesSmall.Add("Faerie",("Faerie",20,49,"War Scythes"));
            enemiesSmall.Add("Selkie",("Selkie",22,54,"Seal Skin Clubs"));
            enemiesSmall.Add("Wisp",("Wisp",24,59,"Ghostly Apparitions"));
            enemiesSmall.Add("Human Rogue", ("Human Rogue", 1, 5, "Rusty Dagger"));
            enemiesSmall.Add("Human Knight", ("Human Knight", 5, 10, "Steel Sword"));
            enemiesSmall.Add("Goblin", ("Goblin", 2, 6, "Club"));
            enemiesSmall.Add("Goblin Champion", ("Goblin Champion", 3, 8, "Spiked Club"));
        }

        public void MidEnemyDict()
        {
            enemiesMid = new Dictionary<string, (string, int, int, string)>();
            
            enemiesMid.Add("Zombie",("Zombie",45,143,"Rotting fists"));
            enemiesMid.Add("Vampire",("Vampire",47,153,"Claws and Teeth"));
            enemiesMid.Add("Werewolf",("Werewolf",50,163,"Claws and Teeth"));
            enemiesMid.Add("Gorgon",("Gorgon",52,172,"Snake Hair"));
            enemiesMid.Add("Siren",("Siren",54,182,"Sonic Screeches"));
            enemiesMid.Add("Kraken",("Kraken",56,191,"Tentacles"));
            enemiesMid.Add("Mermaid",("Mermaid",58,200,"Fish Tail"));
            enemiesMid.Add("Banshee",("Banshee",62,194,"Wails"));
            enemiesMid.Add("Succubus",("Succubus",64,189,"Seductive Powers"));
            enemiesMid.Add("Incubus",("Incubus",66,179,"Seductive Powers"));
        }

        public void LargeEnemyDict()
        {
            enemiesLarge = new Dictionary<string, (string, int, int, string)>();

            enemiesLarge.Add("Troll",("Troll",52,1730,"Clubs"));
            enemiesLarge.Add("Giant",("Giant",55,1830,"Clubs"));
            enemiesLarge.Add("Ice Golem",("Ice Golem",57,1940,"Frozen fists"));
            enemiesLarge.Add("Fire Golem",("Fire Golem",60,2000,"Burning fists"));
            enemiesLarge.Add("Stone Golem",("Stone Golem",65,1940,"Stone fists"));
            enemiesLarge.Add("Demon",("Demon",68,1890,"Hellish Blades"));
            enemiesLarge.Add("Angel",("Angel",70,1790,"Holy Blades"));
            enemiesLarge.Add("Dragon",("Dragon",75,1740,"Claws and Teeth"));
            enemiesLarge.Add("Unicorn",("Unicorn",80,1690,"Horn"));
            enemiesLarge.Add("Phoenix",("Phoenix",85,1640,"Flames"));
        }

    }
}
