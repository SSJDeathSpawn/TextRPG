using System;
using TextRPG.Data;
using TextRPG.Data.Registry;
using TextRPG.Living;
using TextRPG.Location;

namespace TextRPG {
    class Program {
        public static EnemyDataDungeon enemyData;
        public static Registry registry;
        
        static void Main(string[] args) {
            enemyData = new EnemyDataDungeon();
            registry = new Registry();
        }
    }
}
