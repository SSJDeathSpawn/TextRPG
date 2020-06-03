using System;
using TextRPG.Data;
using TextRPG.Living;
using TextRPG.Location;

namespace TextRPG {
    class Program {
        public static EnemyDataDungeon enemyData;
        
        static void Main(string[] args) {
            enemyData = new EnemyDataDungeon();
            Places.init();
            foreach(Place p in Places.places) {
                Console.WriteLine(p.name);
                Console.WriteLine("Connection: ");
                if(p.connection.north!= null)Console.WriteLine("North: " + p.connection.north.name);
                if(p.connection.south!= null)Console.WriteLine("South: " + p.connection.south.name);
                if(p.connection.east!= null)Console.WriteLine("East: " + p.connection.east.name);
                if(p.connection.west!= null)Console.WriteLine("West: " + p.connection.west.name);
                if(p.connection.outside!= null)Console.WriteLine("Outside: " + p.connection.outside.name);
                if(p.connection.ne!= null)Console.WriteLine("North-East: " + p.connection.ne.name);
                if(p.connection.nw!= null)Console.WriteLine("North-West: " + p.connection.nw.name);
                if(p.connection.se!= null)Console.WriteLine("South-East: " + p.connection.se.name);
                if(p.connection.sw!= null)Console.WriteLine("South-West: " + p.connection.sw.name);
                Console.WriteLine("==========================================================");
            }
            Console.ReadLine();
        }
    }
}
