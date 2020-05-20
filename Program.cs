using System;
using TextRPG.Data;
using TextRPG.Living;
using TextRPG.Location;

namespace TextRPG {
    class Program {
        public static EnemyDataDungeon enemyData;
        static void Main(string[] args) {
            enemyData = new EnemyDataDungeon();

            Console.WriteLine("Hello World!");
            Console.WriteLine("Second Line!");
            Console.WriteLine("I edited this, YAY!");
        }
    }
}
