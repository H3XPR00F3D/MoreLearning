using System.Collections.Generic;

namespace MoreLearning.Dungeon
{
    public class Weapons
    {
        //weapon dict. contains name, name, damage, block, description, broken, value)
        public static Dictionary<string, (string, int, int, string, bool, int)> meleeWeapon;
        public static void MeleeDict()
        {
            meleeWeapon = new Dictionary<string, (string, int, int, string, bool, int)>();
            meleeWeapon.Add("Rusty Dagger", ("Rusty Dagger", 2, 2, "A rusty Iron Dagger", false, 1));
            meleeWeapon.Add("Sharp Dagger", ("Sharp Dagger", 3, 3, "A sharpened Dagger", false, 2));
            meleeWeapon.Add("Hand Axe", ("Hand Axe", 4, 4, "A small Hand Axe of wood and steel", false, 3));
            //meleeWeapon.Add("Dagger", ("Dagger", 5, 5, "A rusty Iron Dagger", false, 4));
            //meleeWeapon.Add("Dagger", ("Dagger", 5, 5, "A rusty Iron Dagger", false, 5));
            //meleeWeapon.Add("Dagger", ("Dagger", 5, 5, "A rusty Iron Dagger", false, 6));
        }
    }
}