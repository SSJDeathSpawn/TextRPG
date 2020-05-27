using System;
using System.Collections.Generic;
using TextRPG.Living;

namespace TextRPG.Location {
    public class Dungeon: Place {
        public int recommededLvl;
        public List<Mob> enemies;

        public Dungeon(string name, int recommededLvl, List<Mob> enemies, string desc): base(name, desc) {
            this.recommededLvl = recommededLvl;
            this.enemies = enemies;
        }

        public override void register() {
            base.register();
        }

    }
}