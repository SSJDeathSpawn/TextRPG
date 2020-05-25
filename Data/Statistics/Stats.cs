using System;
using System.Collections.Generic;

namespace TextRPG.Data.Statistics { 
    public class Stats: BaseStats {
        public int hp;
        public int maxHp;
        public int mp;
        public int maxMp;

        public Stats(int str, int dex, int wis, int chr, int con, int wil, int hp, int mp) : base(str, dex, wis, chr, con, wil) {
            this.hp = hp;
            maxHp = this.con * 50;
            this.mp = mp;
            maxMp = this.wil * 40;
        }

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