using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoreLearning.Dungeon
{
    public class Enemies
    {
        public static Dictionary<string, (string, int, int, string,int)> enemiesSmall;
        public static  Dictionary<string, (string, int, int, string,int)> enemiesMid;
        public static Dictionary<string, (string, int, int, string,int)> enemiesLarge;
        public static void SmallEnemyDict()
        {
            enemiesSmall = new Dictionary<string, (string, int, int, string, int)>();

            enemiesSmall.Add("Gizmo",("Gizmo",5,14,"Poisoned Daggers",15));
            enemiesSmall.Add("Satyr",("Satyr",8,19,"Scimitars",20));
            enemiesSmall.Add("Naiad",("Naiad",10,24,"Water Orbs",25));
            enemiesSmall.Add("Salamander",("Salamander",12,29,"Fire Blades",30));
            enemiesSmall.Add("Brownie",("Brownie",14,34,"Large Hammer",35));
            enemiesSmall.Add("Nymph",("Nymph",15,39,"Slingshots",40));
            enemiesSmall.Add("Dryad",("Dryad",18,44,"Wooden Clubs",45));
            enemiesSmall.Add("Faerie",("Faerie",20,49,"War Scythes",50));
            enemiesSmall.Add("Selkie",("Selkie",22,54,"Seal Skin Clubs",55));
            enemiesSmall.Add("Wisp",("Wisp",24,59,"Ghostly Apparitions",60));
            enemiesSmall.Add("Human Rogue", ("Human Rogue", 1, 5, "Rusty Dagger",1));
            enemiesSmall.Add("Human Knight", ("Human Knight", 5, 10, "Steel Sword",5));
            enemiesSmall.Add("Goblin", ("Goblin", 2, 6, "Club",5));
            enemiesSmall.Add("Goblin Champion", ("Goblin Champion", 3, 8, "Spiked Club",10));
        }
        public static void MidEnemyDict()
        {
            enemiesMid = new Dictionary<string, (string, int, int, string, int)>();

            enemiesMid.Add("Zombie", ("Zombie", 45, 143, "Rotting fists", 65));
            enemiesMid.Add("Vampire", ("Vampire", 47, 153, "Claws and Teeth", 70));
            enemiesMid.Add("Werewolf", ("Werewolf", 50, 163, "Claws and Teeth", 75));
            enemiesMid.Add("Gorgon", ("Gorgon", 52, 172, "Snake Hair", 80));
            enemiesMid.Add("Siren", ("Siren", 54, 182, "Sonic Screeches", 85));
            enemiesMid.Add("Kraken", ("Kraken", 56, 191, "Tentacles", 90));
            enemiesMid.Add("Mermaid", ("Mermaid", 58, 200, "Fish Tail", 95));
            enemiesMid.Add("Banshee", ("Banshee", 62, 194, "Wails", 100));
            enemiesMid.Add("Succubus", ("Succubus", 64, 189, "Seductive Powers", 105));
            enemiesMid.Add("Incubus", ("Incubus", 66, 179, "Seductive Powers", 110));
        }
        public static void LargeEnemyDict()
        {
            enemiesLarge = new Dictionary<string, (string, int, int, string, int)>();

            enemiesLarge.Add("Troll", ("Troll", 52, 730, "Clubs", 120));
            enemiesLarge.Add("Giant", ("Giant", 55, 830, "Clubs", 125));
            enemiesLarge.Add("Ice Golem", ("Ice Golem", 57, 940, "Frozen fists", 130));
            enemiesLarge.Add("Fire Golem", ("Fire Golem", 60, 200, "Burning fists", 135));
            enemiesLarge.Add("Stone Golem", ("Stone Golem", 65, 940, "Stone fists", 140));
            enemiesLarge.Add("Demon", ("Demon", 68, 890, "Hellish Blades", 145));
            enemiesLarge.Add("Angel", ("Angel", 70, 790, "Holy Blades", 150));
            enemiesLarge.Add("Dragon", ("Dragon", 75, 740, "Claws and Teeth", 155));
            enemiesLarge.Add("Unicorn", ("Unicorn", 80, 690, "Horn", 160));
            enemiesLarge.Add("Phoenix", ("Phoenix", 85, 640, "Flames", 170));
        }

    }
}
