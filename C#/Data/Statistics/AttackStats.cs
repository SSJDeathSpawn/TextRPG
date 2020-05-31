using System;
using System.Collections.Generic;

namespace TextRPG.Data.Statistics {
    public class AttackStats: Stats {
        public int physStr { get; set; }
        public int magicStr { get; set; }
        public int PsyStr { get; set; }
        public int luck { get; set; }

        public AttackStats(int str, int dex, int wis, int chr, int con, int wil, int hp, int mp, int physStr, int magicStr, int PsyStr, int luck): base(str, dex, wis, chr, con, wil, hp, mp) {
            this.physStr = physStr;
            this.magicStr = magicStr;
            this.PsyStr = PsyStr;
            this.luck = luck; 
        }

    }
}