using System;
using System.Collections.Generic;

namespace TextRPG{ 
    class Stats: BaseStats {
        public int hp;
        public int maxHp;
        public int mp;
        public int maxMp;

        public override void onStatChange(BaseStats newStats) {
            if (con != newStats.con) {
                hp += (newStats.con - con) * 50;
            }
            if (wil != newStats.wil) {
                mp += (newStats.wil - wil) * 50;
            } 
            maxHp = con * 50;
            maxMp = wil * 40;
            str = newStats.str;
            dex = newStats.dex;
            wis = newStats.wis;
            chr = newStats.chr;
            con = newStats.con;
            wil = newStats.wil;
        }
    }
}