using System;
using System.Collections.Generic;

namespace TextRPG.Data.Statistics {
    public abstract class BaseStats {
        public int str { get; set; }
        public int dex { get; set; }
        public int wis { get; set; }
        public int chr { get; set; }
        public int con { get; set; }
        public int wil { get; set; }

        public abstract void onStatChange(BaseStats newStats);

        public BaseStats(int str, int dex, int wis, int chr, int con, int wil) {
            this.str = str;
            this.dex = dex;
            this.wis = wis;
            this.chr = chr;
            this.con = con;
            this.wil = wil;
        }
    }
}