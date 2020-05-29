using System;
using System.Collections.Generic;
using TextRPG.Data.Statistics;
using TextRPG.Data;

namespace TextRPG.Living {
    public class Mob: CharacterUpgraded{
        public (int, int) lvlRange;
        public string desc;

        public static Race monster = new Race();

        public Mob(string name, int lvlRange1, int lvlRange2, string desc, AttackStats stats): base(name, monster, stats) {
            this.lvlRange = (lvlRange1,lvlRange2);
            this.desc = desc;
        }

        public override void register() {
            base.register();
        }
    }
}