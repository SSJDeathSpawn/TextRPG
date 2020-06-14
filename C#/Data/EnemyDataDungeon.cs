using System;
using System.Collections.Generic;
using TextRPG.Living;
using TextRPG.Location;
using TextRPG.Data.Statistics;
using TextRPG.Data.Declarations;

namespace TextRPG.Data{
    public class EnemyDataDungeon{
        public List<Mob> starterDungeon { get; set; } = new List<Mob>();

        public EnemyDataDungeon() {
            this.addEverything();
        }

        public void addEverything() {
            starterDungeon.Add(Mobs.goblin);
        }

    }
}