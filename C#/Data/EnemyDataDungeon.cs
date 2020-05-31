using System;
using System.Collections.Generic;
using TextRPG.Living;
using TextRPG.Location;
using TextRPG.Data.Statistics;

namespace TextRPG.Data{
    public class EnemyDataDungeon{
        public List<Mob> starterDungeon { get; set; } = new List<Mob>();

        public EnemyDataDungeon() {
            this.addEverything();
        }

        public void addEverything() {
            starterDungeon.Add(new Mob("Goblin", 1, 2, "A vile, small and green creature with terrible clothing. Their intelligence is no better than that of animals and they mostly rely on instinct. They steal the goods of adventurers that died near their home.", new AttackStats(1, 1, 1, 1, 1, 0, 50, 0, 5, 0, 0, 5 )));
        }

    }
}