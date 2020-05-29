using System;
using TextRPG.Living;
using TextRPG.Data.Statistics;

namespace TextRPG.Objects {
    public class Items {

        public static Item basicHerb = new Item("Basic Herb", 20, ItemRarity.NORMAL, basic_herb, "A simple herb that doesn't look very appetising. It can supposedly heal wounds, (+5 HP < MaxHP)");

        //Methods

        private static void basic_herb(CharacterUpgraded chara) {
            Stats stat = chara.stats; 
            if (stat.hp < (stat.maxHp - 9)){
                stat.hp += 10;
                chara.stats.onStatChange(stat);
            }
        }
    }
}