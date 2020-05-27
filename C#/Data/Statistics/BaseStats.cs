using System;
using System.Collections.Generic;

namespace TextRPG.Data.Statistics {
    public abstract class BaseStats {
        public int str;
        public int dex;
        public int wis;
        public int chr;
        public int con;
        public int wil;

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