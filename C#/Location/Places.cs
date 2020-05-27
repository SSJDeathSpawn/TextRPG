using System;
using System.Collections.Generic;
using TextRPG.Living;
using TextRPG.Data;
using TextRPG.Data.Handlers;
using System.IO;

namespace TextRPG.Location{
    public class Places{
        static string path = Directory.GetCurrentDirectory() + "\\Resources\\Places\\";

        public static List<Place> places = new List<Place>();

        public static void init() {
            List<Place> tempPlace = new List<Place>();
            Dictionary<Place, TextRPG.Resources.Templates.Connection> tempCon = new Dictionary<Place, Resources.Templates.Connection>();
            Console.WriteLine(path);
            if( Directory.Exists(path)) {
                foreach(string i in Directory.GetDirectories(path)) {
                    foreach(string file in Directory.GetFiles(i)) {
                        TextRPG.Resources.Templates.Place temp = JsonHandler.convertJsonIntoClass<TextRPG.Resources.Templates.Place>(file); 
                        Place temp2 = new Place(temp.Name, temp.Description); 
                        tempPlace.Add(temp2);
                        tempCon.Add(temp2, temp.Connection);
                    }
                    foreach(KeyValuePair<Place, TextRPG.Resources.Templates.Connection> d in tempCon) {
                        d.Key.connection = Connection.convertToActual(d.Value, tempPlace); 
                        places.Add(d.Key);
                    }
                } 
            }
        }

        //public static Dungeon starterDungeon = new Dungeon("Starter Dungeon", 1, Program.enemyData.starterDungeon);
    }
}