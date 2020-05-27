using System;
using TextRPG.Living;
using TextRPG.Data.Statistics;

namespace TextRPG.Objects {
    public class Items {

        public static Item basicHerb = new Item("Basic Herb", 20, true, ItemRarity.NORMAL, basic_herb);


        //Methods
        private static void basic_herb(Character chara) {
            Stats stat = chara.stats; 
            if (stat.hp < (stat.maxHp - 9)){
                stat.hp += 10;
                chara.stats.onStatChange(stat);
            }
        }
    }
}