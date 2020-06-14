using System;
using System.Collections.Generic;
using TextRPG.Data.Statistics;
using TextRPG.Data;

namespace TextRPG.Living {
    public class Mob: CharacterUpgraded{
        public (int, int) lvlRange { get; set; } 
        public string desc { get; set; }

        public static Race monster = new Race("Monster", "A race of no specific characteristics. They have varying intelligence and no real distinguishing features. They are also not necessarily friendly with each other");

        public Mob(string name, int lvlRange1, int lvlRange2, string desc, AttackStats stats): base(name, monster,Gender.DONTCARE, stats) {
            this.lvlRange = (lvlRange1,lvlRange2);  
            this.desc = desc;
        }
    }
}