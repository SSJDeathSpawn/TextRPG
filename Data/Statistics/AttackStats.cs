using System;
using System.Collections.Generic;

namespace TextRPG.Data.Statistics {
    public class AttackStats: Stats {
        public int physStr;
        public int magicStr;
        public int PsyStr;
        public int luck;

        public AttackStats(int str, int dex, int wis, int chr, int con, int wil, int hp, int mp, int physStr, int magicStr, int PsyStr, int luck): base(str, dex, wis, chr, con, wil, hp, mp) {
            this.physStr = physStr;
            this.magicStr = magicStr;
            this.PsyStr = PsyStr;
            this.luck = luck; 
        }

    }
}