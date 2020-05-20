using System;
using System.Collections.Generic;
using TextRPG.Living;
using TextRPG.Data;

namespace TextRPG.Location{
    public class Places{
        public static Dungeon starterDungeon = new Dungeon("Starter Dungeon", 1, Program.enemyData.starterDungeon);
    }
}